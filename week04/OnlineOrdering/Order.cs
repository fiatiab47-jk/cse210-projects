using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor initializes the order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Adds a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculates the total cost of order including shipping
    public double GetTotalCost()
    {
        double total = 0;

        // Add the cost of each product
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost based on customer location
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }


    //Returns a packing label listing product names and IDs
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    } 


    // Returns a shipping label with customer name and address
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetShippingAddress()}";
    }
}