let searchBtn = document.getElementById("search-btn");
let countryInp = document.getElementById("country-inp");
let searchAllBtn = document.getElementById("search-all-btn");
let searchAllWrapper = document.getElementById("search-all-wrapper");
let searchAllContent = document.getElementById("search-all-content");
let open = false;

searchBtn.addEventListener("click", () => {
    let countryName = countryInp.value;
    let finalURL = `http://localhost:3001/getcountry/${countryName}`;
    console.log(finalURL);
    fetch(finalURL).then((response) => response.json()).then((data) => {
        console.log(data.imagesource);

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
                    <span>${data.population}</span>
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
});
searchAllBtn.addEventListener("click", () => {
        console.log("log");
        if(open === false){
            let finalURL = `http://localhost:3001/getcountries`;
    
            fetch(finalURL).then((response) => response.json()).then((data) => {
                console.log(data);
                let fullHTML = "";
                for (i = 0; i < data.length; i++) {
                    fullHTML += "<span>" + data[i].countryname + "</span>\n<br>";
                } 
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