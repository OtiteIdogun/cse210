using System;

public class Customer
{
    private string _name;
    private Address _address;
   

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to return whether customer live in the USA or not.
    public bool LivesInUSA()
    {
        return _address.InUSA();
    }
   
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}

