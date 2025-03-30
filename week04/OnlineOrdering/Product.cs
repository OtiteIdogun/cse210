using System;
using System.Collections.Generic;

public class Product
{
    private string _productId;   
    private string _productName;
    private double _productPrice;
    private int _productQuantity;

    public Product(string productId, string productName, double productPrice, int productQuantity)
    {
        _productId = productId;
        _productName = productName;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public double TotalCostOfProduct()
    {
        double productTotalCost = _productPrice * _productQuantity;
        return productTotalCost;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public int GetProductQuantity()
    {
        return _productQuantity;
    }

    public double GetProductPrice()
    {
        return _productPrice;
    }
}

