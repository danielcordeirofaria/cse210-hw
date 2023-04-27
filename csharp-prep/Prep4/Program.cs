using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a List of Numbers, type 0 when finished.");
        int number = 1;
        string numberInString;
        List<int> numbers = new List<int>();
        while(number != 0){
            Console.WriteLine("Enter number: ");
            numberInString = Console.ReadLine();            
            number = Int32.Parse(numberInString);
            numbers.Add(number);

        }
        int sum = 0;
        float average = 0;
        int largestNumber = 0;
        foreach(int num in numbers){
            sum += num;
            if(num > largestNumber){
                largestNumber = num;
            }

        }

        average = sum / numbers.Count;
        Console.WriteLine($"The average of the all numbers entered is " + average);
        Console.WriteLine($"The sum of the all numbers entered is " + sum);
        Console.WriteLine($"The largest number is: " + largestNumber);
        Console.WriteLine($"The sorted list is: ");
        numbers.Sort();
        foreach(int num in numbers){
            Console.WriteLine(num);
        }


    }
}