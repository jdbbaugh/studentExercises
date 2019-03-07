using System;

namespace studendExercises
{
  public class Instructor
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public Cohort CohortNumber { get; set; }

    public Instructor(string firstName, string lastName, string slack, Cohort cohort) {
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = slack;
      CohortNumber = cohort;
    }

    public void AssignExercise(Student student,Exercise exercise) {

      student.CurrentExercises.Add(exercise);
      Console.WriteLine($"Assigned {student.FirstName} {exercise.Name}");
    }
  }
}