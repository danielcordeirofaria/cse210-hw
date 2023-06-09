using System;
using System.Threading;

class BreathingActivity : Activity
{
    private string _wellcomeMessage;
    public BreathingActivity(string name, string description, string duration, string message) : base(name, description, duration, message)
    {
    }

    public void StartBreathing()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        slashInCircling(3);
        Console.Clear();
        timing();
    }

    public void slashInCircling(int times){
        for(int i = 0; i < times; i++){
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("—");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

        }
    }

    public void breathIn()
    {   
        Console.Write("Breathe in....");
        for (int i = 3; i > 0; i--)
        {
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
        Console.Write("\b \b");
        Console.WriteLine(); 

    }
    public void breathOut()
    {
        Console.Write("Now breathe out....");

        for (int i = 3; i > 0; i--)
        {
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
            // Console.Write("\b \b");
        }
        Console.Write("\b \b");
        Console.WriteLine(); 
        Console.WriteLine(); 
    }

    public void timing(){
        int time = int.Parse(GetDuration())/6;
        for(int i = 0; i < time; i++){
            breathIn();
            breathOut();
        }
        Console.WriteLine("Well done!");
        Console.WriteLine(base.GetMessage());
        slashInCircling(3);
    }

}
