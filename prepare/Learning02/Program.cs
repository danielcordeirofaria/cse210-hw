using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Itau Bank";
        job1._startYear = "2022";
        job1._endYear = "2023";

        job1.Display();

    }
}