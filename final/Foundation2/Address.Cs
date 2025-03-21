using System;
using System.IO;

public class Address
{
    private string _streetaAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private string _address;

    // This method checks if the address is in the USA or not
    public virtual bool IsInUSA()
    {
        return true;
    }
    
    // This string will return the full address with newline characters where appropriate
    public string Address()
    {
        return _address;
    }

}


// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)