using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Teacher genericTeacher = new Teacher("Sanvy", 35);
            SubjectTeacher subjectTeacher = new SubjectTeacher("ramee", 40, "Physics");
            ClassTeacher classTeacher = new ClassTeacher("sundar", 30, "Class A");

           
            CClass class1 = new CClass("Class A");

            
            class1.AddTeacher(genericTeacher);
            class1.AddTeacher(subjectTeacher);
            class1.AddTeacher(classTeacher);

            
            Console.WriteLine("Class: " + class1.ClassName);
            Console.WriteLine("Teachers: ");
            foreach (var teacher in class1.Teachers)
            {
                teacher.Teach();
            }
            Console.ReadKey();
        }
    }

}


