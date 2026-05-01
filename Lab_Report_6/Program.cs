using System;

namespace StudentResultCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declarations
            int subject1, subject2, subject3;
            int totalMarks;
            double percentage;
            bool isPass;
            string grade;

            // Input marks for 3 subjects
            Console.WriteLine("=== STUDENT RESULT CALCULATOR ===\n");

            Console.Write("Enter marks for Subject 1 (0-100): ");
            subject1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 2 (0-100): ");
            subject2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 3 (0-100): ");
            subject3 = Convert.ToInt32(Console.ReadLine());

            // Arithmetic operators - Calculate total and percentage
            totalMarks = subject1 + subject2 + subject3;
            percentage = (double)totalMarks / 300 * 100;

            // Display calculated values
            Console.WriteLine($"\n--- RESULTS ---");
            Console.WriteLine($"Total Marks: {totalMarks} / 300");
            Console.WriteLine($"Percentage: {percentage:F2}%");

            // Relational operators - Check pass/fail condition
            // Passing criteria: minimum 40 marks in each subject AND overall 40%
            bool passEachSubject = (subject1 >= 40) && (subject2 >= 40) && (subject3 >= 40);
            bool passOverall = percentage >= 40;

            // Logical operator (&&) - Combine conditions
            isPass = passEachSubject && passOverall;

            // Display pass/fail status
            if (isPass)
            {
                Console.WriteLine("\nStatus: PASS ✅");

                // Logical operators for grade determination
                if (percentage >= 80 && percentage <= 100)
                {
                    grade = "A+ (Distinction)";
                }
                else if (percentage >= 70 && percentage < 80)
                {
                    grade = "A (First Division)";
                }
                else if (percentage >= 60 && percentage < 70)
                {
                    grade = "B+ (Second Division)";
                }
                else if (percentage >= 50 && percentage < 60)
                {
                    grade = "B (Second Division)";
                }
                else if (percentage >= 40 && percentage < 50)
                {
                    grade = "C (Pass Division)";
                }
                else
                {
                    grade = "Not Assigned";
                }

                Console.WriteLine($"Grade: {grade}");
            }
            else
            {
                Console.WriteLine("\nStatus: FAIL ❌");

                // Show the reason for failure using logical operators
                if (!passEachSubject)
                {
                    Console.WriteLine("Reason: Secured less than 40 marks in one or more subjects.");

                    // Show which subjects failed
                    if (subject1 < 40) Console.WriteLine("  - Subject 1 is below passing marks");
                    if (subject2 < 40) Console.WriteLine("  - Subject 2 is below passing marks");
                    if (subject3 < 40) Console.WriteLine("  - Subject 3 is below passing marks");
                }
                else if (!passOverall)
                {
                    Console.WriteLine("Reason: Overall percentage is below 40%.");
                }
                grade = "No Grade (Failed)";
                Console.WriteLine($"Grade: {grade}");
            }

            // Additional expression evaluation examples
            Console.WriteLine("\n--- OPERATOR DEMONSTRATION ---");

            // Arithmetic expression
            int average = totalMarks / 3;
            Console.WriteLine($"Average Marks: {average}");

            // Modulus operator (remainder)
            int remainderCheck = totalMarks % 2;
            Console.WriteLine($"Total marks is {(remainderCheck == 0 ? "even" : "odd")}");

            // Complex logical expression
            bool scholarshipEligible = (percentage >= 85) && (subject1 >= 80) &&
                                       (subject2 >= 80) && (subject3 >= 80);
            Console.WriteLine($"Scholarship Eligible: {(scholarshipEligible ? "Yes" : "No")}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
