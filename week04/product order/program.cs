using System;
using System.Collections.Generic;
using OnlineOrdering;  // Import Address and Customer

class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    public string GetPackingLabel()
    {
        return $"{name} (ID: {productId}) - Quantity: {quantity}";
    }
}

class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        decimal shippingCost = customer.LivesInUSA() ? 5 : 35;
        total += shippingCost;
        
        // Apply discount if total before shipping is above $50
        if (total - shippingCost > 50)
        {
            total *= 0.9m; // Apply 10% discount
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping To:\n" + customer.GetShippingLabel();
    }
}

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 19.99m, 2));
        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\n------------------\n");
        
        Address address2 = new Address("45 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "P003", 49.99m, 1));
        order2.AddProduct(new Product("Monitor", "P004", 129.99m, 1));
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}
