
using System;

class StudentResultCalculator
{
    static void Main()
    {
        // Declare variables
        int subject1, subject2, subject3;
        int total;
        double percentage;
        bool isPass;

        // Input marks
        Console.Write("Enter marks for Subject 1: ");
        subject1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        subject2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        subject3 = Convert.ToInt32(Console.ReadLine());

        // Arithmetic operations
        total = subject1 + subject2 + subject3;
        percentage = total / 3.0;

        // Relational + Logical operators (pass condition: each subject >= 40)
        isPass = (subject1 >= 40) && (subject2 >= 40) && (subject3 >= 40);

        // Display results
        Console.WriteLine("\nTotal Marks = " + total);
        Console.WriteLine("Percentage = " + percentage + "%");

        // Pass/Fail
        if (isPass)
        {
            Console.WriteLine("Result: PASS");

            // Grade calculation using logical operators
            if (percentage >= 80)
                Console.WriteLine("Grade: A+");
            else if (percentage >= 70 && percentage < 80)
                Console.WriteLine("Grade: A");
            else if (percentage >= 60 && percentage < 70)
                Console.WriteLine("Grade: B");
            else if (percentage >= 50 && percentage < 60)
                Console.WriteLine("Grade: C");
            else
                Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Result: FAIL");
            Console.WriteLine("Grade: F");
        }

        Console.ReadLine();
    }
}