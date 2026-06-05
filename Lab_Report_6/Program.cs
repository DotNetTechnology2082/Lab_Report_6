using System;

class StudentResult
{
    static void Main()
    {
        // Variables
        int mark1, mark2, mark3;
        int total;
        double percentage;

        Console.Write("Enter marks for Subject 1: ");
        mark1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        mark2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        mark3 = Convert.ToInt32(Console.ReadLine());

        total = mark1 + mark2 + mark3;
        percentage = total / 3.0;

        bool isPass = (mark1 >= 40) && (mark2 >= 40) && (mark3 >= 40);

        string grade;

        if (percentage >= 80)
            grade = "A";
        else if (percentage >= 60 && percentage < 80)
            grade = "B";
        else if (percentage >= 40 && percentage < 60)
            grade = "C";
        else
            grade = "F";

        Console.WriteLine("\nTotal Marks: " + total);
        Console.WriteLine("Percentage: " + percentage);

        if (isPass)
            Console.WriteLine("Result: Pass");
        else
            Console.WriteLine("Result: Fail");

        Console.WriteLine("Grade: " + grade);
    }
}