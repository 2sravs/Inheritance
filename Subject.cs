using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SubjectTeacher : Teacher
    {
        public string Subject { get; set; }

        public SubjectTeacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public new void Teach()
        {
            Console.WriteLine(Name + " is teaching " + Subject + ".");
        }
    }
}
