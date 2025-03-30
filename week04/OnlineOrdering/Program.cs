using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("P001", "Laptop", 500.00, 1);
        Product product2 = new Product("P002", "Mouse", 25.00, 2);
        Product product3 = new Product("P003", "Keyboard", 49.99, 1);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order2.AddProduct(product3);


        // Calculate total costs and get labels
        Console.WriteLine($"Order 1 Total Cost: {order1.TotalPrice():C}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Order 2 Total Cost: {order2.TotalPrice():C}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}


