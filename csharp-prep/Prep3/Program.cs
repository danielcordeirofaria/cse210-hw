using System;

class Program
{
    static void Main(string[] args)
    {
         Random random = new Random();
        int magicNumber = random.Next(101);
        Console.WriteLine($"The magic number is between 0 and 100. What is your guess?");

        while(true){
            try{
                magicNumber = Int32.Parse(Console.ReadLine());
                break; // sair do loop se a conversão for bem-sucedida
            }catch{
                Console.Write("This is not an integer number. Please enter an integer number: ");
            }
        };
        Console.Write("What is your guess? ");
        while(true){
            try{
                int guessMagicNumber = Int32.Parse(Console.ReadLine());
                if(guessMagicNumber > magicNumber){
                    Console.Write("Your guess number is higher than the magic number. Please guess again: ");
                }else if(guessMagicNumber < magicNumber){
                    Console.Write("Your guess number is lower than the magic number. Please guess again: ");
                }else{
                    Console.Write("Congratulations! You guessed the magic number! ");
                    break; // sair do loop se a suposição estiver correta
                }

            }catch{
                Console.Write("This is not an integer number. Please enter an integer number: ");
            }
        }
    }
}
