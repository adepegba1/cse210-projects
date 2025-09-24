using System;  
// This lets us use basic C# functionality (like Console, strings, etc.).

public class Customer  
// Defines a new class called "Customer" (a blueprint for creating customer objects).

{
    private string _customerName;  
    // A private variable to store the customer's name.
    
    private Address _address;  
    // A private variable to store the customer's address (this is another class).

    public Customer(string name, Address address)  
    // This is a constructor. It runs when you create a new Customer.
    // It requires two pieces of info: a name (string) and an address (Address object).
    {
        _customerName = name;  
        // Save the name provided into the _customerName field.
        
        _address = address;  
        // Save the address object provided into the _address field.
    }

    public bool LiveInUSA()
    // A method that returns true/false depending on whether the customer lives in the USA.
    {
        return _address.IsUSA();
        // Calls the IsUSA() method from the Address class to check the country.
        // return _address.GetCountry().ToUpper() == "USA";
    }

    public string DisplayCustomer()  
    // A method that returns the customer's name and full address as a single string.
    {
         string address = _address.DisplayAddress();  
        // Call the DisplayAddress() method from Address class to get the full address string.
        
        return ($"Customer Name: {_customerName}\n{address}");  
        // Return a nicely formatted string that includes the customer name and their address.
    }
}
