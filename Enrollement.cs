using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollement
{
    internal class Enrollement
    {
        static void Main(string[] args)
        {
            OnlineCourse c1 = new OnlineCourse();
            InPersonCourse c2 = new InPersonCourse();
            LabCourse c3 = new LabCourse();

            c1.coursename = ".Net";
            c1.Enroll("Rama");

            c2.coursename = "DataBase";
            c2.Enroll("Janaki");

            c3.coursename = "ReactJS";
            c3.Enroll("SitaRama");
        }
    }

}
