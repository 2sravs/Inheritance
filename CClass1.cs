using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class CClass
    {
        public string ClassName { get; set; }
        public List<Teacher> Teachers { get; set; }

        public CClass(string className)
        {
            ClassName = className;
            Teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
    }
}
