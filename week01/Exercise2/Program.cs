using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade: ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);
        string letterGrade = "";
        string letterSymbol = "";

        if (numberGrade >= 70)
        {
            if (numberGrade % 10 >= 7)
            {
                if (numberGrade >= 90)
                {
                    letterGrade = "A";
                }
                else if (numberGrade >= 80)
                {
                    letterGrade = "B";
                    letterSymbol = "+";
                }
                else
                {
                    letterGrade = "C";
                    letterSymbol = "+";
                }
            }
            else if (numberGrade % 10 < 3)
            {
                letterSymbol = "-";
                if (numberGrade >= 90)
                {
                    letterGrade = "A";
                }
                else if (numberGrade >= 80)
                {
                    letterGrade = "B";
                }
                else
                {
                    letterGrade = "C";
                }
            }
            else
            {
                if (numberGrade > 90)
                {
                    letterGrade = "A";
                }
                else if (numberGrade > 80)
                {
                    letterGrade = "B";
                }
                else
                {
                    letterGrade = "C";
                }
            }
            Console.WriteLine($"Your letter grade is {letterGrade}{letterSymbol}");
            Console.WriteLine("Congratulation you pass the course");
        }
        else
        {
            if (numberGrade >= 60)
            {
                if (numberGrade % 10 >= 7)
                {
                    letterSymbol = "+";
                    letterGrade = "D";
                }
                else if (numberGrade % 10 < 3)
                {
                    letterSymbol = "-";
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "D";
                }
                Console.WriteLine($"Your letter grade is {letterGrade}{letterSymbol}");
            }
            else
            {
                letterGrade = "F";
                Console.WriteLine($"Your letter grade is {letterGrade}");
            }
            Console.WriteLine("You failed the course, try again next time");
        }


        // if (numberGrade >= 70)
        // {
        //     if (numberGrade >= 90)
        //     {
        //         letterGrade = "A";
        //         Console.WriteLine(letterGrade);
        //     }
        //     else if (numberGrade >= 80)
        //     {
        //         letterGrade = "B";
        //         Console.WriteLine(letterGrade);
        //     }
        //     else if (numberGrade >= 70)
        //     {
        //         letterGrade = "C";
        //         Console.WriteLine(letterGrade);
        //     }
        //     Console.WriteLine("Congratulation you pass the course");
        // }
        // else
        // {
        //     if (numberGrade >= 60)
        //     {
        //         letterGrade = "D";
        //         Console.WriteLine(letterGrade);
        //     }
        //     else
        //     {
        //         letterGrade = "F";
        //         Console.WriteLine(letterGrade);
        //     }
        //     Console.WriteLine("You failed the course, try again next time");
        // }
    }


}