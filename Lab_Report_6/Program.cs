using System;

class Program
{
    static void Main()
    {
        int sub1, sub2, sub3, total, fullMarks = 300;
        double percentage;

        // Taking input
        Console.Write("Enter marks of Subject 1: ");
        sub1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks of Subject 2: ");
        sub2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks of Subject 3: ");
        sub3 = Convert.ToInt32(Console.ReadLine());

        // Arithmetic operations
        total = sub1 + sub2 + sub3;
        percentage = Math.Round((total / (double)fullMarks) * 100);  // If one operand is double, the whole division becomes double.

        Console.WriteLine("Total Marks = " + total);
        Console.WriteLine("Percentage = " + percentage);

        // Relational + Logical operations (Pass/Fail)
        if (sub1 >= 40 && sub2 >= 40 && sub3 >= 40)
        {
            Console.WriteLine("Result: Pass");

            // Grade calculation
            if (percentage >= 80)
                Console.WriteLine("Grade: Distinction");
            else if (percentage >= 60)
                Console.WriteLine("Grade: First Division");
            else if (percentage >= 50)
                Console.WriteLine("Grade: Second Division");
            else
                Console.WriteLine("Grade: Third Division");
        }
        else
        {
            Console.WriteLine("Result: Fail");
        }
    }
}