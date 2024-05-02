using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Missionary Training Center";
        job1._jobTitle = "Instructor";
        job1._startYear = "2022";
        job1._endYear = "2024";

        Job job2 = new Job();
        job2._company = "Family Search";
        job2._jobTitle = "Administration Assistant";
        job2._startYear = "2024";
        job2._endYear = "Present";

        Resume myResume = new Resume();
        myResume._name = "Amon Reis";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();

        
    }
}