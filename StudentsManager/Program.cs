using StudentService;

StudentService.StudentService studentService = new StudentService.StudentService();

Console.WriteLine(string.Join(", ", studentService.GetStudentsAboveTheAgeOf19()));

Console.WriteLine(string.Join(", ", studentService.GetStudentsBetweenTheAgesOf19And21()));

Console.WriteLine(studentService.GetNumberOfStudentsContainingLetterHInName());

Console.WriteLine(studentService.GetNumberOfStudentsContainingLetterOInName());

Console.WriteLine(string.Join(", ", studentService.GetNamesOfStudentsAged17()));



var studentArray = new Student[]
           {
                new Student() { StudentID = 11, StudentName = "Anna", Age = 27 },
                new Student() { StudentID = 12, StudentName = "Bobby", Age = 20 },
                new Student() { StudentID = 13, StudentName = "Billy", Age = 22 },
                new Student() { StudentID = 14, StudentName = "Tom", Age = 17 },
                new Student() { StudentID = 15, StudentName = "Ronny", Age = 16 },
           };

var aggregatedStudentList = studentService.GetStudents().Concat(studentArray);

Console.WriteLine(string.Join(", ", aggregatedStudentList));