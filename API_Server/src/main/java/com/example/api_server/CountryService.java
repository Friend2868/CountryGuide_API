package com.example.api_server;
import java.util.*;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CountryService {
    @Autowired
    private CountryRepository countryRepository;

    //private List<Rezept> rezepte = new ArrayList<>(Arrays.asList());

    public List<Country> getallCountries() {
        return (List<Country>) this.countryRepository.findAll();
    }

    public Optional<Country> getCountry(String countryname) {
        return this.countryRepository.findByCountryname(countryname);
    }

    public void addCountry(Country country) {
        this.countryRepository.save(country);
    }

    public void updateCountry(Country country, String countryname) {
        this.countryRepository.deleteByCountryname(countryname);
        this.countryRepository.save(country);
    }

    public void deleteCountry(String countryname) {
        this.countryRepository.deleteByCountryname(countryname);
    }
}
