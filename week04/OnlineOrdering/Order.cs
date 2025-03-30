using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void SetShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            _shippingCost = 5;
        }
        else if (!(_customer.LivesInUSA()))
        {
            _shippingCost = 35;
        }
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        packingLabel += "Products:\n";
        foreach (var product in _products)
        {
            packingLabel += $"- {product.GetProductName()} (ID: {product.GetProductId()}, Price: {product.GetProductPrice()}, Quantity: {product.GetProductQuantity()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {_customer.GetName()}\n";
        shippingLabel += $"Address: \n{_customer.GetAddress().AllAddressFields()}\n";
        return shippingLabel;
    }
    
    public double TotalPrice()
    {
        // Calculate total price as the sum of the total
        // cost of each product plus a one-time shipping cost
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            SetShippingCost();
            totalPrice += product.TotalCostOfProduct() + _shippingCost;
        }
        return totalPrice;
    }
}
