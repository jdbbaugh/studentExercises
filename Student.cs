using System;
using System.Collections.Generic;

namespace studendExercises
{
  public class Student {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }

    public Cohort CohortNumber { get; set; }
    public List<Exercise> currentExercises{ get; set; }

  }
}