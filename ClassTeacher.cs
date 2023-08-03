using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ClassTeacher : Teacher
    {
        public string ClassName { get; set; }

        public ClassTeacher(string name, int age, string className) : base(name, age)
        {
            ClassName = className;
        }

        public new void Teach()
        {
            Console.WriteLine(Name + " is teaching " + ClassName + " class.");
        }
    }
}
