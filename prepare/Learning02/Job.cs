 public class Job{
    public String _jobTitle;
    public String _company;
    public String _startYear;
    public String _endYear;

    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
 }