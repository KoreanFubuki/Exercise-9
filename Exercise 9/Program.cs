using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            Console.WriteLine("Enter The points of your students remember that the points are from 0 to 20");
            while (true)
            {
                Console.Write("Enter Score: ");
                string input = Console.ReadLine();

                if (input == "-1")
                {
                    if (count == 0)
                    {
                        Console.WriteLine("No score has been entered");
                    }
                    else
                    {
                        double average = (double)sum / count;

                        Console.WriteLine($"Average score: {average:F2}");
                    }
                    break;
                }
                if (int.TryParse(input, out int score))
                {
                    if (score >= 0 && score <= 20)
                    {
                        sum += score;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid score. Please enter a score between 0 and 20.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. please enter a valid number or -1 to calculate the average score");
                }
            }
            Console.Read();
        }
    }
}

