using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    internal class Student
    {
        private string name;
        private int age;
        private string grade;

        public Student(string name, int age, string grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Grade { get => grade; set => grade = value; }
    }
}
