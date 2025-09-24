using System;  
// Gives access to basic C# system features like Console, strings, etc.

public class Address
{
    // These are private variables (fields) that store the details of the address
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor: This method runs when you create a new Address object.
    // It takes the street, city, state, and country as input and saves them in the private fields.
    public Address(string street, string city, string state, string country)
    {
        _street = street;   // Save the street value inside _street
        _city = city;       // Save the city value inside _city
        _state = state;     // Save the state value inside _state
        _country = country; // Save the country value inside _country
    }

    // Method to check if the address is in the USA
    // It changes the country string to uppercase and compares it with "USA"
    public bool IsUSA()
    {
        return _country.ToUpper() == "USA";
    }

    // Method to display the full address in a neat format.
    // "\n" means "new line", so each part will show on its own line.
    public string DisplayAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    // Method to return just the country part of the address.
    public string GetCountry()
    {
        return _country;
    }
}
