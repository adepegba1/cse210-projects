// Allow access to basic .NET types and functionality (standard import).
using System;

// Declare an abstract base class named Shape.
// "abstract" means you cannot create a Shape directly — only subclasses that implement the abstract members.
public abstract class Shape
{
    // A private field that stores the color of the shape.
    // The underscore prefix (_color) is a common convention for private fields.
    private string _color;

    // Constructor for the Shape class.
    // This runs when a derived shape object is created and sets the initial color.
    public Shape(string color)
    {
        // Store the provided color value into the private _color field.
        _color = color;
    }

    // Public method to change the shape's color after the object has been created.
    // This provides controlled write access to the private field.
    public void SetColor(string color)
    {
        _color = color;
    }

    // Public method to read the shape's color.
    // This provides controlled read access to the private field.
    public string GetColor()
    {
        return _color;
    }

    // Abstract method that declares a contract for computing the area.
    // There is no implementation here — every concrete subclass must provide its own GetArea() method
    // that returns the shape's area as a double (e.g., circle, rectangle, triangle).
    public abstract double GetArea();

} // End of Shape class
