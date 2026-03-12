using System.Reflection;

namespace UniversityEnrollement
{
    class Course
    {
        public string coursename;
          

    }
    class OnlineCourse : Course
    {
        public void Enroll(string studentname)
        {
            if (studentname != " ")
                Console.WriteLine(studentname + "Enrolled in Online Course : " + coursename);
            else
                Console.WriteLine("Invalid student name");
        }
    }
    class InPersonCourse : Course
    {
        public void Enroll(string studentname)
        {
            if (studentname != " ")
                Console.WriteLine(studentname + "Enrolled in In - Person Course : " + coursename);
            else
                Console.WriteLine("Invalid student name");
        }
    }
    class LabCourse : Course
    {
        public void Enroll(string studentname)
        {
            if (studentname != " ")
                Console.WriteLine(studentname + "Enrolled in Lab Course : " + coursename);
            else
                Console.WriteLine("Invalid student name");
        }
    }
}
