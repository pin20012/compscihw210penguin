using System;
using System.IO;

public class Customer
{
    private string _customerName;
    
    public Address
    
    // The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
    public virtual bool IsInUSA()
    {
        return true;
    }
}



// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)