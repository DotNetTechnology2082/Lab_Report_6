using System;

class StudentResult
{
    static void Main()
    {
        int sub1, sub2, sub3, total;
        double percentage;

        // Input marks
        Console.Write("Enter marks for Subject 1: ");
        sub1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        sub2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        sub3 = Convert.ToInt32(Console.ReadLine());

        // Arithmetic operations
        total = sub1 + sub2 + sub3;
        percentage = total / 3.0;

        // Display total and percentage
        Console.WriteLine("Total Marks = " + total);
        Console.WriteLine("Percentage = " + percentage);

        // Relational + Logical operators (Pass/Fail)
        if (sub1 >= 40 && sub2 >= 40 && sub3 >= 40)
        {
            Console.WriteLine("Result: Pass");

            // Grade calculation
            if (percentage >= 80)
                Console.WriteLine("Grade: A");
            else if (percentage >= 60)
                Console.WriteLine("Grade: B");
            else if (percentage >= 50)
                Console.WriteLine("Grade: C");
            else
                Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Result: Fail");
        }
    }
}
