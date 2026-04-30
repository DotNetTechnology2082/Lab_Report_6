using System;

class StudentResultCalculator
{
    static void Main(string[] args)
    {
        // ─── Variables ───────────────────────────────────────────
        double marks1, marks2, marks3;
        double total, percentage;
        string grade;
        bool passed;

        // ─── Input ───────────────────────────────────────────────
        Console.WriteLine("========================================");
        Console.WriteLine("       STUDENT RESULT CALCULATOR        ");
        Console.WriteLine("========================================");

        Console.Write("Enter marks for Subject 1 (out of 100): ");
        marks1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 2 (out of 100): ");
        marks2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 3 (out of 100): ");
        marks3 = Convert.ToDouble(Console.ReadLine());

        // ─── Arithmetic Operators ─────────────────────────────────
        total = marks1 + marks2 + marks3;         // addition
        percentage = (total / 300) * 100;              // division + multiplication

        // ─── Relational Operators ─────────────────────────────────
        // Each subject must be >= 40 to pass
        bool pass1 = marks1 >= 40;
        bool pass2 = marks2 >= 40;
        bool pass3 = marks3 >= 40;

        // ─── Logical Operators ────────────────────────────────────
        // && (AND): all subjects must be passed
        passed = pass1 && pass2 && pass3;

        // ─── Grade Logic (logical operators) ─────────────────────
        if (!passed)                                   // ! (NOT)
        {
            grade = "F - Fail";
        }
        else if (percentage >= 90)
        {
            grade = "A+ - Outstanding";
        }
        else if (percentage >= 80 && percentage < 90)  // && (AND)
        {
            grade = "A - Excellent";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            grade = "B - Good";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            grade = "C - Satisfactory";
        }
        else if (percentage >= 50 && percentage < 60)
        {
            grade = "D - Passing";
        }
        else
        {
            grade = "F - Fail";
        }

        // ─── Output ───────────────────────────────────────────────
        Console.WriteLine("\n========================================");
        Console.WriteLine("              RESULT CARD               ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Subject 1 Marks  : {marks1}");
        Console.WriteLine($"Subject 2 Marks  : {marks2}");
        Console.WriteLine($"Subject 3 Marks  : {marks3}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Total Marks      : {total} / 300");
        Console.WriteLine($"Percentage       : {percentage:F2}%");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Result           : {(passed ? "PASS" : "FAIL")}");
        Console.WriteLine($"Grade            : {grade}");
        Console.WriteLine("========================================");

        // ─── Operator Summary (for learning) ─────────────────────
        Console.WriteLine("\n--- Operator Trace ---");
        Console.WriteLine($"[Arithmetic]  total = {marks1} + {marks2} + {marks3} = {total}");
        Console.WriteLine($"[Arithmetic]  percentage = ({total} / 300) * 100 = {percentage:F2}");
        Console.WriteLine($"[Relational]  marks1 >= 40 → {pass1}");
        Console.WriteLine($"[Relational]  marks2 >= 40 → {pass2}");
        Console.WriteLine($"[Relational]  marks3 >= 40 → {pass3}");
        Console.WriteLine($"[Logical &&]  pass1 && pass2 && pass3 → {passed}");
        Console.WriteLine($"[Logical !]   !passed → {!passed}");
    }
}