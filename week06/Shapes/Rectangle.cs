// Import the System namespace which provides basic system types (strings, console, etc.)
// It's common to include even if not directly used in this small file.
using System;

// Define a new class named Rectangle that inherits from a base class called Shape.
// Inheritance (the ": Shape" part) means Rectangle will have all behavior of Shape plus its own.
public class Rectangle : Shape
{
    // Private field to store the rectangle's width.
    // "private" means only methods inside this class can access _width directly.
    private double _width;

    // Private field to store the rectangle's length.
    private double _length;

    // Constructor for Rectangle. Called when you create a new Rectangle object.
    // It accepts a color (passed to the Shape base class), width, and length.
    public Rectangle(string color, double width, double length) : base(color)
    {
        // Store the constructor's length argument in the private field _length.
        _length = length;
        // Store the constructor's width argument in the private field _width.
        _width = width;
    }

    // Override the GetArea method that is defined in the base Shape class.
    // "override" means this Rectangle version replaces the parent's implementation.
    public override double GetArea()
    {
        // Calculate and return the area of the rectangle (length × width).
        return _length * _width;
    }
}
