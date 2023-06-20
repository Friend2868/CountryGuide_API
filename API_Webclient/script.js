let searchBtn = document.getElementById("search-btn");
let countryInp = document.getElementById("country-inp");
let searchAllBtn = document.getElementById("search-all-btn");
let searchAllWrapper = document.getElementById("search-all-wrapper");
let searchAllContent = document.getElementById("search-all-content");
let open = false;

searchAllBtn.addEventListener("click", () => {
        if(open === false){
            let finalURL = `http://localhost:3001/getcountries`;
    
            fetch(finalURL).then((response) => response.json()).then((data) => {
                data.sort(function(a, b){
                    var nameA = a.countryname.toLowerCase(), nameB = b.countryname.toLowerCase();
                    if (nameA < nameB)
                     return -1;
                    if (nameA > nameB)
                     return 1;
                    return 0; 
                   });
                let fullHTML = "";
                for (i = 0; i < data.length; i++) {
                    fullHTML += "<button onclick=\"getCountry('" + data[i].countryname + "');\">" + data[i].countryname + "</button>\n<br>";
                } 
                console.log(fullHTML);
                searchAllBtn.textContent = "Hide Available";
                searchAllContent.innerHTML += "<br>" + fullHTML;
            })
            open = true;
        }
        else{
            searchAllBtn.textContent = "Available Countries";
            searchAllContent.innerHTML = " ";
            open = false;
        }
});
function getCountryByName () {
    getCountry(countryInp.value);
}
function getCountry (countryInp) {
    let countryName = countryInp;
    let finalURL = `http://localhost:3001/getcountry/${countryName}`;
    console.log(finalURL);

    fetch(finalURL).then((response) => response.json()).then((data) => {
        var cpopulation = (data.population).toLocaleString(
            undefined, { minimumFractionDigits: 0 }
          );

        result.innerHTML = `
            <img src="${data.imagesource}" class="flag-img">
            <h2>${data.countryname}</h2>
            <div class="wrapper">
                <div class="data-wrapper">
                    <h4>Capital:</h4>
                    <span>${data.capital}</span>
                </div>
            </div>
            <div class="wrapper">
                <div class="data-wrapper">
                    <h4>Continent:</h4>
                    <span>${data.continent}</span>
                </div>
            </div>
            <div class="wrapper">
                <div class="data-wrapper">
                    <h4>Population:</h4>
                    <span>${cpopulation}</span>
                </div>
            </div>
            <div class="wrapper">
                <div class="data-wrapper">
                    <h4>Currency:</h4>
                    <span>${data.currency}</span>
                </div>
            </div>
            <div class="wrapper">
                <div class="data-wrapper">
                    <h4>Common Languages:</h4>
                    <span>${Object.values(data.common_languages).toString().split(",").join(", ")}</span>
                </div>
            </div>
        `;
    })
} 