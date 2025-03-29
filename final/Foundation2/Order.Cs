using System;
using System.IO;
using System.Runtime.Intrinsics.Wasm;

public class Order
{
    //Attributes
    private Customer _customer;
    private Address _address;

    List<Product> _products = new List<Product>();
   
    //Methods

    //Constructor
   public Order(Customer customer, Address address)
   {
        _customer = customer;
        _address = address;
   }
   public void AddProduct(Product product)
   {
        _products.Add(product);
   }

    // This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
    public string OrderCostSummary()
    {
        // to find the total price of the products, I set the variable to zero
        //The foreach loop then goes through each of the products
        // the products are added up using the Total() method (product price per unit multiplied by quantity)
        double productPriceTotal = 0;
        foreach (Product product in _products)
        {
            productPriceTotal += product.Total();
        }
        // after the foreach loop, the overall total is calculated. We make a call to the IsInUSAorNot() method to see how much shipping will be
        double overallTotal = productPriceTotal + (_customer.IsInUSAorNot() ? 5 : 35);
        Console.WriteLine();
        // I didn't know how to round, so I asked chat for some help
        // The .ToString("F2") converts the number to a string with 2 decimal places
        // I also wanted to take this a step further by displaying the subtotal cost and shipping cost
        return $"Subtotal: ${productPriceTotal.ToString("F2")}\nShipping Cost: ${(_customer.IsInUSAorNot() ? 5 : 35)}\nCost After Shipping: ${overallTotal.ToString("F2")}";
    }

    // A packing label should list the name and product id of each product in the order.
    public string CreatePackingLabel()
    {
        Console.WriteLine($"PACKING LABEL:");
        string packingLabel = "";
        foreach(Product p in _products)
        {
            // This wasn't working right, so i asked chat for some help, it said to use += to add the prdouct name and ID and not replace it with a
            // different product name and ID
            packingLabel += p.ProductNameAndID() + "\n";
        }
        return packingLabel;
    }

    // A shipping label should list the name and address of the customer
    public string CreateShippingLabel()
    {
        Console.WriteLine($"SHIPPING LABEL:");
        return $"{_customer.GetCustomer()}\n{_address.FullAddress()}";
    }
}

// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.