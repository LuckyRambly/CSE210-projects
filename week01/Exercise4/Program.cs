using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project. ");

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number or type 0 to quit: ");

            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The total sum is: {sum} ");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is:{max} ");
    }
}