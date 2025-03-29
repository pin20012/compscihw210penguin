using System;

class Program
{
    static void Main(string[] args)
    {

        Address a1 = new Address("458 Cherry Hill", "Casper", "Wyoming", "United States");
        Address a2 = new Address("145 Aerial Street", "Paris", "France", "Europe");
        Address a3 = new Address("5902 Channing Avenue", "Fort Lauderale", "Florida", "United States");

        Customer c1 = new Customer("Jackson Brisket", a1);
        Customer c2 = new Customer("Sophie Mayonesa", a2);
        Customer c3 = new Customer("Marion Fritter", a3);
       
        Product p1 = new Product("Bread", 2423, 2.24, 2);
        Product p2 = new Product("Lettuce", 2122, 1.53, 1);
        Product p3 = new Product("Tomatoes", 2118, 2.07, 3);
        Product p4 = new Product("Bacon", 1322, 5.08, 1);
        Product p5 = new Product("Mayo", 1322, 2.25, 1);
        Product p6 = new Product("Cheese", 1322, 3.08, 1);

        Order o1 = new Order(c1, a1);
        Order o2 = new Order(c2, a2);
        Order o3 = new Order(c3, a3);

        o1.AddProduct(p3);
        o1.AddProduct(p4);
        o1.AddProduct(p5);

        o2.AddProduct(p2);
        o2.AddProduct(p3);
        o2.AddProduct(p1);

        o3.AddProduct(p6);
        o3.AddProduct(p2);
        o3.AddProduct(p4);

        //Chat gave me an idea for how to make the display more apppealing
        Console.WriteLine($"===========================================");
        Console.WriteLine($"                  ORDER 1                  ");
        Console.WriteLine($"===========================================");
        Console.WriteLine(o1.CreatePackingLabel());
        Console.WriteLine(o1.CreateShippingLabel());
        Console.WriteLine(o1.OrderCostSummary());
        Console.WriteLine();

        Console.WriteLine($"===========================================");
        Console.WriteLine($"                  ORDER 2                  ");
        Console.WriteLine($"===========================================");
        Console.WriteLine(o2.CreatePackingLabel());
        Console.WriteLine(o2.CreateShippingLabel());
        Console.WriteLine(o2.OrderCostSummary());
        Console.WriteLine();

        Console.WriteLine($"===========================================");
        Console.WriteLine($"                  ORDER 3                  ");
        Console.WriteLine($"===========================================");
        Console.WriteLine(o3.CreatePackingLabel());
        Console.WriteLine(o3.CreateShippingLabel());
        Console.WriteLine(o3.OrderCostSummary());
        Console.WriteLine();
    }
}