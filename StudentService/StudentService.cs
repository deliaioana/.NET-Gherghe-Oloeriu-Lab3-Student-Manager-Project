namespace StudentService
{
    public class StudentService
    {
        private Student[] studentArray;

        public Student[] GetStudents()
        {
            return studentArray;
        }

        public StudentService()
        {
            StudentFactory studentFactory = new StudentFactory();
            studentArray = studentFactory.Create();
        }

        public List<Student> GetStudentsAboveTheAgeOf19()
        {
            List<Student> filteredList = studentArray.Where(student => student.Age > 19).ToList();
            return filteredList;
        }

        public List<Student> GetStudentsBetweenTheAgesOf19And21()
        {
            List<Student> filteredList = studentArray.Where(student => student.Age > 19 && student.Age < 21).ToList();
            return filteredList;
        }

        public int GetNumberOfStudentsContainingLetterHInName()
        {
            List<Student> filteredList = studentArray.Where(student => student.StudentName.Contains('H') ||
                                                                        student.StudentName.Contains('h')).ToList();
            return filteredList.Count;
        }

        public int GetNumberOfStudentsContainingLetterOInName()
        {
            List<Student> filteredList = studentArray.Where(student => student.StudentName.Contains('O') ||
                                                                        student.StudentName.Contains('o')).ToList();
            return filteredList.Count;
        }

        public List<string> GetNamesOfStudentsAged17()
        {
            List<string> filteredList = studentArray.Where(student => student.Age == 17).
                                                    Select(student => student.StudentName).ToList();
            return filteredList;
        }
    }
}
