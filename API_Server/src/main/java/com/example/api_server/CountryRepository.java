package com.example.api_server;
import org.springframework.data.mongodb.repository.MongoRepository;

import java.util.Optional;

public interface CountryRepository extends MongoRepository<Country, String> {
    void deleteByCountryname(String countryname);
    Optional<Country> findByCountryname(String countryname);
}
