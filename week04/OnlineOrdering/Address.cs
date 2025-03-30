using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to return whether country is in the USA or not 
    public bool InUSA()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string AllAddressFields()
    {
        // Return a string for all address fields together in one string
        // (with newline characters where appropriate)
        return $"{_streetAddress} \n{_city}, {_state} \n{_country}";
    }
}


