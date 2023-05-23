package com.example.api_server;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;
@RestController
public class CountryController {
        @RequestMapping("/")
        public String serviceTest(){
            return "Das Service funktioniert!";
        }
        @Autowired
        private CountryService countryService;

        @CrossOrigin(origins = "http://127.0.0.1:5500")
        @RequestMapping("/getcountries")
        public List<Country> getallCountries() {
            return countryService.getallCountries();
        }

        @CrossOrigin(origins = "http://127.0.0.1:5500")
        @RequestMapping("/getcountry/{countryname}")
        public Optional<Country> getCountry(@PathVariable String countryname) {
            return countryService.getCountry(countryname);
        }

        @RequestMapping(method=RequestMethod.POST, value="/addCountry")
        public String addCountry(@RequestBody Country country) {
            countryService.addCountry(country);
            String response = "{\"success\": true, \"message\": Country was added successfully.}";
            return response;
        }

        @DeleteMapping("/deleteRezept/{rezeptname}")
        public String deleteCountry(@PathVariable String countryname) {
            countryService.deleteCountry(countryname);
            String response = "{\"success\": true, \"message\": Country was deleted successfully.}";
            return response;
        }
}
