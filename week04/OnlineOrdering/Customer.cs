using System;

public class Customer
{
    private string _name;
    private Address _address;

    // Constructor initializes customer name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Returns the customer's name
    public string GetName()
    {
        return _name;
    }

    // Returns true if customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Return the full address of the customer
    public string GetShippingAddress()
    {
        return _address.GetFullAddress();
    }

}   
