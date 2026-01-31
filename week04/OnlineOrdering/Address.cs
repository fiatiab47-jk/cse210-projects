using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor initializes the address
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Returns true if the address is in the USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}\n{_state}\n{_country}";
    }
}