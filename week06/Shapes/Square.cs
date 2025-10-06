// Allow use of basic .NET types (not strictly required here, but common to include)
using System;

// Define a new class named Square that inherits from a base class called Shape
// Inheritance (" : Shape") means Square gets the behavior and data of Shape and can extend it
public class Square : Shape
{
    // A private field that stores the length of one side of the square
    // "private" means only code inside this class can access _side directly
    private double _side;

    // Constructor for Square — this runs when someone creates a new Square object
    // It takes a color (passed up to the base Shape class) and the side length for this square
    // ": base(color)" calls the Shape constructor to let the parent class initialize its data
    public Square(string color, double side) : base (color)
    {
        // Store the side length passed by the caller into the private field _side
        _side = side;
    }

    // This method overrides a method defined in the base Shape class (must be virtual/abstract there)
    // It provides the Square-specific calculation for area — required because different shapes compute area differently
    public override double GetArea()
    {
        // Area of a square = side × side
        return _side * _side;
    }
}
