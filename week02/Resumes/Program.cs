using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Aspen";
        job1._jobTitle = "Account Coordinator";
        job1._startYear = "2025";
        job1._endYear = "present";

        Job job2 = new Job();
        job2._company = "FamilySearch";
        job2._jobTitle = "Help & Operations Specialist";
        job2._startYear = "2024";
        job2._endYear = "2025";

        Job job3 = new Job();
        job3._company = "Brazil Missionary Training Center";
        job3._jobTitle = "Trilingual Instructor";
        job3._startYear = "2022";
        job3._endYear = "2024";

        Resume resume1 = new Resume();
        resume1._name = "Amon Reis";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);
        
        resume1.DisplayResume();

    }
}