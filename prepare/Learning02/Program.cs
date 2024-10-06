using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //Creat an instance of the class Job, and object named job1:
        Job job1 = new Job();

        //Assign values to job1 variables:
        job1._jobTitle = "Project Planner and Controller";
        job1._company = "Emec Limitada";
        job1._startYear = 2023;
        job1._endYear = 2024;

        //Creat an instance of the class Job, and object named job2:
        Job job2 = new Job();

        //Assign values to job2 variables:
        job2._jobTitle = "Planning ITO";
        job2._company = "Suringen SpA";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Creat an instance of the class Resume, and object named myResume:
        Resume myResume = new Resume();

        //Assign a value to myResume._name variable:
        myResume._name = "Alberto Villanueva";

        //Append the list job1 and job2 into the object named myResume:
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Display myResule details:
        myResume.DisplayResumeDetails();

    }
}