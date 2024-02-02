using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    internal class Student
    {
        private int positon;
        private string name;
        private int age;
        private string grade;

        public Student(int positon, string name, int age, string grade)
        {
            this.positon = positon;
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Grade { get => grade; set => grade = value; }
        public int Positon { get => positon; set => positon = value; }
    }
}
