using System;

namespace studendExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise learnJavaScript = new Exercise()
            {
                Name = "Make a user input",
                CodeLanguage = "JavaScript"
            };
            Exercise learnReact = new Exercise()
            {
                Name = "Make a React App",
                CodeLanguage = "React"
            };
            Exercise learnCSharp = new Exercise()
            {
                Name = "Make a List",
                CodeLanguage = "C#"
            };
            Exercise learnDotNet = new Exercise()
            {
                Name = "Make a Dictionary",
                CodeLanguage = ".NET"
            };
            // Create 3, or more, cohorts.
            Cohort cohort28 = new Cohort("Cohort 28");
            Cohort cohort29 = new Cohort("Cohort 29");
            Cohort cohort30 = new Cohort("Cohort 30");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student student1 = new Student("Jimbo", "Gimbo", "slack/jmbo", cohort28);
            cohort28.Students.Add(student1);
            Student student2 = new Student("Julia", "Gulia", "slack/jules", cohort29);
            cohort29.Students.Add(student2);
            Student student3 = new Student("Hernando", "Smith", "slack/herns", cohort29);
            cohort29.Students.Add(student3);
            Student student4 = new Student("Jill", "Schmill", "slack/herns", cohort30);
            cohort30.Students.Add(student4);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Jisie = new Instructor("Jisie", "David", "slack/jisieD", cohort30);
            cohort30.Instructors.Add(Jisie);
            Instructor Andy = new Instructor("Andy", "Collins", "slack/andyC", cohort29);
            cohort30.Instructors.Add(Andy);
            Instructor Leah = new Instructor("Leah", "Hollen", "slack/andyC", cohort28);
            cohort30.Instructors.Add(Leah);

            // Have each instructor assign 2 exercises to each of the students.
            Jisie.AssignExercise(learnJavaScript);
            Jisie.AssignExercise(learnReact);
            Andy.AssignExercise(learnCSharp);
            Andy.AssignExercise(learnDotNet);
            Leah.AssignExercise(learnJavaScript);
            Leah.AssignExercise(learnReact);

            // List<string> allStudentsList = new List<string>();


        }
    }
}
