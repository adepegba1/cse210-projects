// Import the System namespace (basic functionality like Console, Math, etc.)
using System;

// Define a class called "Fractions" that represents fractions (like 1/2, 3/4).
public class Fractions
{
    // Two private variables to store the fraction's numerator (_top) and denominator (_bottom).
    private int _top;
    private int _bottom;
    


    public Fractions()
    // Default constructor: If you create a fraction without giving values,
    // it sets the fraction to 1/1 (which equals 1).
    {
        _top = 1;
        _bottom = 1;
    }
    

        public Fractions(int WholeNumber)
         // Constructor with one parameter: If you pass a whole number (like 5),
    // it makes the fraction "5/1", which is just 5 as a fraction.
    {
        _top = WholeNumber;
        _bottom = 1;
    }
   

       public Fractions(int top, int bottom)
        // Constructor with two parameters: lets you create any fraction, e.g., 3/4.
    {
        _top = top;
        _bottom = bottom;
    }
   
    public int GetTop()
    // Returns the numerator of the fraction when called.
    {
        return _top;
    }
    

       public int SetTop(int value)
        // Sets a new value for the numerator and returns it.
    {
        _top = value;
        return _top;
    }
   

       public int GetBottom()
        // Returns the denominator of the fraction when called.
    {
        return _bottom;
    }
   

        public int SetBottom(int value)
        // Sets a new value for the denominator and returns it.
    {
        _bottom = value;
        return _bottom;
    }
    

   
       public string GetFractionString()
       // Returns the fraction as a string, e.g., "3/4".
    {
        return ($"{_top}/{_bottom}");
    }
    
    public double GetDecimalValue()
    // Converts the fraction to a decimal number.
    // Example: if _top = 3 and _bottom = 4, it returns 0.75.
    {
        return _top / (double)_bottom;
    }
    

}
