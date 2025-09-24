// This line lets us use basic C# functionality (like Console.WriteLine, Lists, etc.)
using System;  

// Define a class called Order, which represents a customer's order
public class Order
{
    // A list of all the products included in this order
    private List<Product> _products;

    // The customer who made this order
    private Customer _customer;

    // Constructor: when you create an Order, you must give a customer and a list of products
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;        // Save the given customer inside this order
        _products = products;    // Save the given products inside this order
    }

    // Method to calculate the total cost of the order (products + shipping)
    public double TotalCost()
    {
        double sum = 0;              // Start with total sum = 0
        int shippingFee = 5;         // Default shipping fee (for USA customers)

        // Go through each product in the order
        foreach (Product product in _products)
        {
            // Add the total cost of this product (price * quantity) to the sum
            sum += product.TotalCost();
        }

        // If the customer lives in the USA, add only $5 for shipping
        if (_customer.LiveInUSA())
        {
            return Math.Round(sum + shippingFee,2);
        }
        else
        {
            // Otherwise (international), change shipping fee to $35
            shippingFee = 35;
            return Math.Round(sum + shippingFee,2);
        }
    }

    // Method to display the packing label
    // A packing label lists all product names and IDs
    public void PackingLabel()
    {
        Console.WriteLine("=== Packing Label ==="); // Header text
        foreach (Product product in _products)        // Loop through each product
        {
            // Show product name and product ID
            Console.WriteLine($"Product Name: {product.GetProductName()} | Product Id: {product.GetProductId()}");
        }
    }

    // Method to display the shipping label
    // A shipping label shows the customer details (name + address)
    public void ShippingLabel()
    {
        Console.WriteLine("=== Shipping Label ==="); // Header text
        Console.WriteLine(_customer.DisplayCustomer()); // Print customer details
    }
}
