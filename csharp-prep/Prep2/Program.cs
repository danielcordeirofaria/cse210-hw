using System;

class Program
{
    static void Main(string[] args)
    {
        int intGrade;
        String grade;

        Console.Write("What is your number grade? ");

        grade = Console.ReadLine();

        intGrade = int.Parse(grade);

        if(intGrade < 60){
            Console.WriteLine("Your letter grade is F");
        }
        else if(intGrade >= 90){
            Console.WriteLine("Your letter grade is A");
        }
        else if(intGrade >= 80){
            Console.WriteLine("Your letter grade is B");
        }
        else if(intGrade >= 70){
            Console.WriteLine("Your letter grade is C");
        }
        else if(intGrade >= 60){
            Console.WriteLine("Your letter grade is D");
        }
    }
}