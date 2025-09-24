using System;   
// This allows us to use built-in C# classes like Console for input/output

class Program
{
    static void Main(string[] args)   // The starting point of the program
    {
        // Create the first address for a customer (street, city, state, country)
        Address address1 = new Address("123 Adefemi", "Ikotun", "Lagos", "Nigeria");
        
        // Create the first customer and link them to their address
        Customer customer1 = new Customer("Adepegba David", address1);
        
        // Create a list (collection) to hold all the products for this customer
        List<Product> AllProduct1 = new List<Product>();

        // Add three products to the first customer's order (name, id, price, quantity)
        AllProduct1.Add(new Product("Laptop", 001, 119.99, 12));
        AllProduct1.Add(new Product("Iphone", 002, 18.99, 5));
        AllProduct1.Add(new Product("Bag", 003, 14.99, 14));

        // Create an order for the first customer, including their list of products
        Order customerList1 = new Order(customer1, AllProduct1);

        // Print a packing label (shows product names and IDs)
        customerList1.PackingLabel();

        // Print a shipping label (shows customer name and address)
        customerList1.ShippingLabel();

        // Calculate the total cost (products + shipping fee)
        double cost1 = customerList1.TotalCost();

        // Print the total cost for customer 1
        Console.WriteLine();
        Console.WriteLine($"Total cost of your product is ${cost1}");

        Console.WriteLine(); // Print a blank line for spacing between customers

        // Create the second address for another customer
        Address address2 = new Address("12, Salt Lake", "Salt Lake", "Idaho", "USA");

        // Create the second customer and link them to their address
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create a new product list for this second customer
        List<Product> AllProduct2 = new List<Product>();

        // Add three products to the second customer's order
        AllProduct2.Add(new Product("Mouse", 004, 4.99, 18));
        AllProduct2.Add(new Product("Laptop", 001, 119.99, 10));
        AllProduct2.Add(new Product("Ipad", 006, 69.99, 20));

        // Create an order for the second customer, including their list of products
        Order customerList2 = new Order(customer2, AllProduct2);

        // Print packing label for the second order
        customerList2.PackingLabel();

        // Print shipping label for the second order
        customerList2.ShippingLabel();

        // Calculate total cost for the second customer
        double cost2 = customerList2.TotalCost();

        // Print the total cost for customer 2
        Console.WriteLine();
        Console.WriteLine($"Total cost of your product is ${cost2}");
    }
}
