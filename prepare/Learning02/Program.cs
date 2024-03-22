using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1=new Job();
        job1._company="Microsoft";
        job1._jobTitle="Software Engineer";
        job1._startYear=1999;
        job1._endYear=2024;

        job1.Display_Job();

        Resume user_resume=new Resume();
        user_resume._name="MY NAME";
        user_resume._jobs.Add(job1);
        
        user_resume.DisplayResume();
    }
}