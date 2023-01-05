using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Admission { get; set; }
    public List<CourseStudent> JoinEntities { get; }
  }
}