namespace StudentService
{
    public class StudentFactory
    {
        public Student[] Create()
        {
            var studentArray = new Student[] 
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve", Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill", Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ran", Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron", Age = 23 },
                new Student() { StudentID = 6, StudentName = "Chris", Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob", Age = 19 },
                new Student() { StudentID = 8, StudentName = "Jan", Age = 16 },
                new Student() { StudentID = 9, StudentName = "Job", Age = 17 },
                new Student() { StudentID = 10, StudentName = "Steven", Age = 20 },
            };

            return studentArray;
        }
    }
}
