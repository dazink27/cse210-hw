public class Job{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display_Job()
    {
        Console.WriteLine(@$"
            Company:{_company}
            Job Title: {_jobTitle}
            Starting Year: {_startYear}
            Ending Year: {_endYear}");
    } 
}