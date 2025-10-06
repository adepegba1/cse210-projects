// Import the System namespace so we can use basic .NET types and utilities (for example Math)
using System;

// Define a new public class named Circle that inherits from a base class called Shape
// Inheritance means Circle will get behavior/fields from Shape and can add or override them
public class Circle : Shape
{
    // Private field to store the radius value of this circle instance
    // 'private' means only code inside this class can access _radius directly
    private double _radius;

    // Constructor for Circle — called when you create a new Circle object
    // It accepts a color (string) and a radius (double)
    // The ": base(color)" part calls the parent Shape constructor to initialize the color there
    public Circle(string color, double radius) : base(color)
    {
        // Store the radius passed in into the private field so other methods can use it
        _radius = radius;
    } // end of constructor

    // This method overrides a method named GetArea defined in the base class Shape
    // 'public' makes it accessible from other code, 'override' replaces the base implementation
    public override double GetArea()
    {
        // Calculate and return the area of the circle using the formula π * r^2
        // Math.PI provides π and Math.Pow(_radius, 2) computes radius squared
        return Math.PI * Math.Pow(_radius, 2);
    } // end of GetArea method
} // end of Circle class
