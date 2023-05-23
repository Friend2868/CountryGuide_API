package com.example.api_server;

import org.springframework.data.mongodb.core.mapping.MongoId;

import java.util.List;

public class Country {
    @MongoId
    private String countryname;
    private String capital;
    private String continent;
    private Integer population;
    private String currency;
    private List<String> common_languages;
    private String imagesource;

    public Country() {
    }
    public Country(String countryname, String capital, String continent, Integer population, String currency, List<String> common_languages, String imagesource) {
        this.countryname = countryname;
        this.capital = capital;
        this.continent = continent;
        this.population = population;
        this.currency = currency;
        this.common_languages = common_languages;
        this.imagesource = imagesource;
    }

    public String getCountryname(){
        return countryname;
    }
    public void setCountryname(String countryname){
        this.countryname = countryname;
    }
    public String getCapital() {
        return capital;
    }

    public void setCapital(String capital) {
        this.capital = capital;
    }

    public String getContinent() {
        return continent;
    }

    public void setContinent(String continent) {
        this.continent = continent;
    }

    public Integer getPopulation() {
        return population;
    }

    public void setPopulation(Integer population) {
        this.population = population;
    }

    public String getCurrency() {
        return currency;
    }

    public void setCurrency(String currency) {
        this.currency = currency;
    }

    public List<String> getCommon_languages() {
        return common_languages;
    }

    public void setCommon_languages(List<String> common_languages) {
        this.common_languages = common_languages;
    }
    public String getImagesource(){
        return imagesource;
    }
    public void setImagesource(String imagesource){
        this.imagesource = imagesource;
    }
}
