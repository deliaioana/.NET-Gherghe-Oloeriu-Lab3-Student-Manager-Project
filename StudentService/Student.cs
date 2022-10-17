using System.Threading.Tasks.Dataflow;

namespace StudentService
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return StudentID.ToString() + " " + StudentName + " " + Age.ToString();
        }

    }
}