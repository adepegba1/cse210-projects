using System;  
// This allows us to use basic .NET classes like Console for printing output.

public class Product  
// Defines a class named "Product". A class is like a blueprint for creating objects (things).

{
    private string _productName;  
    // A variable (field) that stores the name of the product (like "Laptop" or "Bag").

    private int _productId;  
    // A variable that stores a unique number (ID) for the product.

    private double _price;  
    // A variable that stores the price of a single unit of the product. "double" means it can have decimals.

    private int _quantity;  
    // A variable that stores how many of this product we have.

    public Product(string productName, int productId, double price, int quantity)  
    // This is a constructor. It runs when you create a new Product object.  
    // It allows you to set the product's name, ID, price, and quantity.

    {
        _productName = productName;  
        // Assigns the value passed in (from the user/program) to the product name field.

        _productId = productId;  
        // Assigns the product ID given to the _productId field.

        _price = price;  
        // Assigns the product price to the _price field.

        _quantity = quantity;  
        // Assigns the quantity of the product to the _quantity field.
    }

    public double TotalCost()  
    // A method (function) that calculates the total cost of this product.  
    // It returns a decimal number (double).

    {
        return _price * _quantity;  
        // Multiplies the unit price by the quantity. Example: $3 × 5 = $15.
    }

    public void DisplayProduct()  
    // A method that shows (prints) the details of the product on the screen.

    {
        Console.WriteLine($"Name: {_productName} Product Id: {_productId} Price: {_price} Quantity: {_quantity}");  
        // Prints out the product’s name, ID, price, and quantity using string interpolation.
    }

    public string GetProductName()  
    // A method that returns the product's name when called.

    {
        return _productName;  
        // Gives back the value stored in _productName.
    }

    public int GetProductId()  
    // A method that returns the product's ID when called.

    {
        return _productId;  
        // Gives back the value stored in _productId.
    }
}
