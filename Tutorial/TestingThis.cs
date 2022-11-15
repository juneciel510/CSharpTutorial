using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class TestingThis
    {
        public void Test()
        {
            Student student = new Student(001, "Jim");
            student.GetStudent();
        }
    }

    class Student
    {
        public int id;
        public string name;
        public Student(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public void GetStudent()
        {
            Console.WriteLine(id + ":" + name);
        }
    }
}
