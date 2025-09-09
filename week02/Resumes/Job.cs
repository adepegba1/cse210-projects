using System;
// Create the class 
public class Job
{
    // Create member variables in the class for each element that this class should contain.
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear;
    public int _endYear;

   
    // Add a Display method to the Job class
    public void Display()
    {
        // Display the content of the job class in this order.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}