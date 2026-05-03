using System;
class studentResult
{
    static void Main()
    {
        int sub1, sub2, sub3, total;
        double percentage;
        Console.WriteLine("Enter marks for subject 1");
        sub1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks for subject 2");
        sub2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks for subject 3");
        sub3 = Convert.ToInt32(Console.ReadLine());

        total = sub1 + sub2 + sub3;
        percentage = (total / 300.0) * 100;
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Percentage: " + percentage + "%");

        if (sub3 >= 40 && sub2 >= 40 && sub1 >= 40)
        {
            Console.WriteLine("Result: PASS");

            if (percentage >= 80)
            {
                Console.WriteLine("Grade: Distinction");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: first division");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade: second division");
            }
            else
            {
                Console.WriteLine("Grade: third division");
            }
        }
        else
        {
            Console.WriteLine("Result: FAIL");

        }
    }
}

