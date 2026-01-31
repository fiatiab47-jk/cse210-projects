using System;

// The product class represent an item that can be ordered
// All data is private and accessed through methods (encapsulation).
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;


    // Constructor initializes all required product data
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // returns the total cost for this product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Returns product name
    public string GetName()
    {
        return _name;
    }

    // Returns product ID
    public string GetProductId()
    {
        return _productId;
    }
}