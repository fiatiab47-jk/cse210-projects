using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the OnlineOrdering Project.");

        // Order 1 (USA Customer)
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "TX",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P1001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");
        Console.WriteLine();

        
        // Order 2 (International Customer)
        Address address2 = new Address(
            "45 King Street",
            "Toronto",
            "ON",
            "Canada"
        );

        Customer customer2 = new Customer("Emily Chen", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Notebook", "P2001", 5, 5));
        order2.AddProduct(new Product("Pen Set", "P2002", 12, 1));
        order2.AddProduct(new Product("Backpack", "P2003", 45, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}