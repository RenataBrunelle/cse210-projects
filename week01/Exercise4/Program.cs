using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 0;
        float sum = 0;
        int max = numbers[0];
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            string info = Console.ReadLine();
            number = int.Parse(info);
            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
            }
            foreach (int currentNumber in numbers)
            {
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }

        } while (number != 0);

        float average = sum / numbers.Count;
        Console.WriteLine($"The sum is : {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}