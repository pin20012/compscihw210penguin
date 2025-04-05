using System;
using System.IO;

public class Customer
{
    //attributes
    private string _customerName;
    private Address _address;

    // Constructor
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    // Methods Found Below
    
    // The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
    public bool IsInUSAorNot()
    {
        return _address.IsInUSAorNot();
    }

    public string GetCustomer()
    {
        return $"{_customerName}";
    }
}

// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)