using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        String name = YourName();
        int number = FavoriteNumber();
        LastMessage(name, number);

    }

    static void WelcomeMessage(){
        Console.WriteLine("Welcome to the program!");
    }

    static String YourName(){
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();
        return name;
    }

    static int FavoriteNumber(){
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = Int32.Parse(Console.ReadLine());
        return favoriteNumber * favoriteNumber;
    }

    static void LastMessage(String brother, int favoriteNumber){
    Console.Write("Brother " + brother + ", the square of your number is " + favoriteNumber);
    }
}