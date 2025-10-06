// Allow use of basic .NET types like Console and Math
using System;

// Define a top-level Program class which holds the Main entry point
class Program
{
    // The program starts here. Main is where execution begins.
    static void Main(string[] args)
    {
        // Create an empty list that will store Shape objects (Square, Circle, Rectangle, etc.)
        // Shape is a base class; the list can hold any object that derives from Shape.
        List<Shape> shapes = new List<Shape>();

        // Create a new Square object with color "Red" and side length 4, then add it to the list
        shapes.Add(new Square("Red", 4));
        // Create a new Circle object with color "Blue" and radius 4, then add it to the list
        shapes.Add(new Circle("Blue", 4));
        // Create a new Rectangle object with color "Yellow", width 3 and height 7, then add it to the list
        shapes.Add(new Rectangle("Yellow", 3, 7));

        // Loop through every Shape object stored in the shapes list, one at a time
        foreach (Shape shape in shapes)
        {
            // For each shape:
            //  - call GetColor() to get the shape's color (string)
            //  - call GetArea() to compute the shape's area (a number)
            //  - Math.Round(..., 2) rounds the area to 2 decimal places for nicer output
            // Then write a line to the console describing the shape's color and area
            Console.WriteLine($"The shape color is {shape.GetColor()} and the area of the shape is {Math.Round(shape.GetArea(), 2)}");
        }

    }
}
