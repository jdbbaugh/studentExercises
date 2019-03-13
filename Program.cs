using System;
using System.Linq;
using System.Collections.Generic;

namespace studendExercises
{
    public class CohortQuery {
        public string CohortName {get; set;}
        public List<string> Students {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise learnJavaScript = new Exercise()
            {
                Name = "LearnJavaScript",
                CodeLanguage = "Javascript"
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
                Name = "Dictionary",
                CodeLanguage = "Javascript"
            };
            Exercise overlyExcited = new Exercise()
            {
                Name = "Make a database that manipulates time.",
                CodeLanguage = ".NET"
            };
            Exercise solarSystem = new Exercise()
            {
                Name = "Learn about planets.",
                CodeLanguage = "C#"
            };
            Exercise carLot = new Exercise()
            {
                Name = "Carlot.",
                CodeLanguage = "Javascript"
            };
            Exercise dynamicCards = new Exercise()
            {
                Name = "Play uno and goFish.",
                CodeLanguage = "React"
            };
            // Create 3, or more, cohorts.
            Cohort cohort28 = new Cohort("Cohort 28");
            Cohort cohort29 = new Cohort("Cohort 29");
            Cohort cohort30 = new Cohort("Cohort 30");
            Cohort cohort31 = new Cohort("Cohort 31");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student student1 = new Student("Jimbo", "Gimbo", "slack/jmbo", cohort28);
            cohort28.Students.Add(student1);
            Student student2 = new Student("Julia", "Gulia", "slack/jules", cohort29);
            cohort29.Students.Add(student2);
            Student student3 = new Student("Hernando", "Smith", "slack/herns", cohort29);
            cohort29.Students.Add(student3);
            Student student4 = new Student("Jill", "Schmill", "slack/herns", cohort30);
            cohort30.Students.Add(student4);
            Student larry = new Student("Larry", "Berry", "slack/larBer", cohort28);
            cohort28.Students.Add(larry);
            Student kristin = new Student("Kristin", "Alberts", "slack/albie", cohort29);
            cohort29.Students.Add(kristin);
            Student loshana = new Student("Loshana", "Obanson", "slack/obslo", cohort29);
            cohort29.Students.Add(loshana);
            Student tre = new Student("Tre", "Strother", "slack/obslo", cohort31);
            cohort31.Students.Add(tre);
            Student bob = new Student("Bob", "Hombre", "slack/obslo", cohort31);
            cohort31.Students.Add(bob);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Jisie = new Instructor("Jisie", "David", "slack/jisieD", cohort30);
            cohort30.Instructors.Add(Jisie);
            Instructor Andy = new Instructor("Andy", "Collins", "slack/andyC", cohort29);
            cohort29.Instructors.Add(Andy);
            Instructor Maddi = new Instructor("Maddi", "Albs", "slack/MaddiC", cohort29);
            cohort29.Instructors.Add(Maddi);
            Instructor Leah = new Instructor("Leah", "Hollen", "slack/leah", cohort28);
            cohort28.Instructors.Add(Leah);
            Instructor Joe = new Instructor("Joe", "Shepherd", "slack/jo", cohort31);
            cohort31.Instructors.Add(Joe);

            // Have each instructor assign 2 exercises to each of the students.
            Jisie.AssignExercise(learnJavaScript);
            Jisie.AssignExercise(learnReact);
            Andy.AssignExercise(learnCSharp);
            Andy.AssignExercise(learnDotNet);
            Leah.AssignExercise(learnJavaScript);
            Leah.AssignExercise(learnCSharp);

            List<Student> students = new List<Student>(){student1, student2,student3,student4};
            List<Exercise> exercises = new List<Exercise>(){learnJavaScript, learnReact, learnCSharp, learnDotNet};

            // foreach(Student student in students){
            //     List<string> studentIsWorkingOn = new List<string>();
            //     foreach(Exercise exercise in student.CurrentExercises){
            //         studentIsWorkingOn.Add(exercise.Name);
            //     }
            //     Console.WriteLine();
            //     Console.WriteLine($"{student.FirstName} {student.LastName} is working on Assignments: {String.Join(", ", studentIsWorkingOn)}");
            // }

            List<Student> moreStudents = new List<Student>(){
                larry,
                kristin,
                loshana,
                tre,
                bob
            };
            moreStudents.AddRange(students);

            List<Exercise> moreExercises = new List<Exercise>() {
                overlyExcited,
                solarSystem,
                carLot,
                dynamicCards
            };

            moreExercises.AddRange(exercises);
            List<Cohort> moreCohorts = new List<Cohort>(){
                cohort28,
                cohort29,
                cohort30,
                cohort31
            };
            List<Instructor> moreInstructors = new List<Instructor>(){
                Jisie,
                Andy,
                Leah,
                Maddi
            };

            Console.WriteLine();
            Console.WriteLine("-----------------------------");


        // List exercises for the JavaScript language by using the Where() LINQ method.

            // List<Exercise> languageQuery = (from ex in moreExercises
            // where ex.CodeLanguage == "Javascript"
            // select ex).ToList();

            var languageQuery = moreExercises.Where(exercise => exercise.CodeLanguage == "Javascript");

            Console.WriteLine("The following exercises use Javascript");
            foreach(Exercise assignment in languageQuery){
                Console.WriteLine(assignment.Name);
            }

            // List students in a particular cohort by using the Where() LINQ method.
            List<Student> studentsInCohort = moreStudents.Where(student => student.CohortNumber == cohort29).ToList();

            Console.WriteLine();
            Console.WriteLine("Students in Cohort 29");
            Console.WriteLine("------------------------");
            foreach(Student student in studentsInCohort){
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }


            // List instructors in a particular cohort by using the Where() LINQ method.
            List<Instructor> instructorsInCohort = moreInstructors.Where(Instructor => Instructor.CohortNumber == cohort29).ToList();
            Console.WriteLine();
            Console.WriteLine("Instructor in Cohort 29");
            Console.WriteLine("------------------------");
            foreach(Instructor inst in instructorsInCohort){
                Console.WriteLine($"{inst.FirstName} {inst.LastName}");
            }



            // Sort the students by their last name.
            // List<Student> studentSort = (from student in moreStudents
            //     orderby student.LastName
            //     select student).ToList();


            var studentSort = moreStudents.OrderBy(stu => stu.LastName);

            Console.WriteLine();
            Console.WriteLine("Students alphabetically");
            Console.WriteLine("-----------------------------------");
                foreach(Student student in studentSort) {
                    Console.WriteLine($"{student.LastName} {student.FirstName}");
                }

            // Display any students that aren't working on any
            // exercises (Make sure one of your student instances don't have
            // any exercises. Create a new student if you need to.)
            List<Student> noWork = moreStudents.Where(student => student.CurrentExercises.Count == 0).ToList();
                        Console.WriteLine();
            Console.WriteLine("Students with no current exercises to work on");
            Console.WriteLine("-----------------------------------");
            foreach(Student student in noWork) {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }




            // TODO:Which student is working on the most exercises? Make sure one of your students has more exercises than the others.

            // TODO: How many students in each cohort?




        }
    }
}
