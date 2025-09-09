using System;

// Create the Resume class.
public class Resume
{
    // Create the member variable for the person's name
    public string _name = "";
    // Create the member variable for the list of Jobs.
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {

    }
    // Add a Display method to the Resume class
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job b in _jobs)
        {
            b.Display();
        }
    }
}