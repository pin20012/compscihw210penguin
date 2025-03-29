using System;
using System.IO;

public class Address
{
    //Attributes
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    //Methods

    //Constructor for the address
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // This method checks if the address is in the USA or not
    // If the address is true then the method will return true
    // If not, the method will return false
    public virtual bool IsInUSAorNot()
    {
        if (_country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
        ;
    }
    
    // This string will return the full address with newline characters where appropriate
    public string FullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }

}


// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)