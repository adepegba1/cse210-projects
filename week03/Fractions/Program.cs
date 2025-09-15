using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions frac = new Fractions(); // Creates 1/1

        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

        Fractions frac1 = new Fractions(5); // Creates 5/1

        
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Fractions frac2 = new Fractions(3, 4); // Creates 3/4

       
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        frac2 = new Fractions(1, 3); // Creates 1/3

        
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());


    }
}