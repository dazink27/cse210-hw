public class Resume{
    public List<Job> _jobs = new List<Job>();
    public string _name;

    public void DisplayResume()
    {
        Console.WriteLine(_name);
        foreach(Job job in _jobs)
        {
            job.Display_Job();
        }
    }

}