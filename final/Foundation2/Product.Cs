using System;
using System.IO;

public class Product
{
    private string _productName;
    private int _productID;
    private double _pricerPerUnit;
    private double _quantity;

    public Product(string productName, int productID, double pricePerUnit, double quantity)
    {
        _productName = productName;
        _productID = productID;
        _pricerPerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double Total()
    {
        
        return _pricerPerUnit * _quantity;
    }

    public string ProductNameAndID()
    {
        return $"{_productName} (ID: {_productID})";
    }
}


// Contains the name, product id, price per unit, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity. 
// If the price per unit was $3 and they bought 5, the product total cost would be $15.