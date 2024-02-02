using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Student myStudent1 = new Student("Nguyễn Văn A", 10, "5D4");
            Student myStudent2 = new Student("Nguyễn Văn B", 9, "4C3");
            Student myStudent3 = new Student("Nguyễn Văn C", 8, "3B2");
            Student myStudent4 = new Student("Nguyễn Văn D", 7, "2A1");
            //2.
            Student[] myStudents = new Student[4];
            myStudents[0] = myStudent1;
            myStudents[1] = myStudent2;
            myStudents[2] = myStudent3;
            myStudents[3] = myStudent4;
            //3.
            ShowAllStudents(myStudents);
            //4.
            SearchName(myStudents, "Nguyễn Văn A");
            //5.
            SearchAge(myStudents, true);
            //6.
            SearchAge(myStudents, false);
            //7.
            ChangeStudent(myStudents, 0, 3);
        }

        private static void ChangeStudent(Student[] students, int oldPos, int newPos)
        {
            Student tempPos;
            tempPos = students[oldPos];
            students[oldPos] = students[newPos];
            students[newPos] = tempPos;
            Console.WriteLine("\nChange position students: ");
            ShowAllStudents(students);
        }

        private static void SearchAge(Student[] students, bool isHighest)
        {
            int indexStudent = 0;
            int tempAge = students[0].Age;
            for(int i = 0; i < students.Length; i++)
            {
                if(isHighest)
                {
                    if (tempAge < students[i].Age)
                    {
                        tempAge = students[i].Age;
                        indexStudent = i;
                    }
                } else
                {
                    if (tempAge > students[i].Age)
                    {
                        tempAge = students[i].Age;
                        indexStudent = i;
                    }
                }
                
            }
            Console.WriteLine($"\nSearch {(isHighest? "highest" : "lowest")} age student:");
            ShowStudentInfomation(students[indexStudent]);
        }

        private static void SearchName(Student[] students, string nameSearch)
        {
            Student searchStudent = null;
            foreach(Student student in students)
            {
                if (student.Name == nameSearch)
                {
                    searchStudent = student;
                }    
            }

            Console.WriteLine("\nSearch name student:");
            if (searchStudent != null)
                ShowStudentInfomation(searchStudent);
            else
                Console.WriteLine("No result");
        }

        private static void ShowAllStudents(Student[] students)
        {
            foreach (Student student in students)
            {
                ShowStudentInfomation(student);
            }
        }

        private static void ShowStudentInfomation(Student myStudent)
        {
            Console.WriteLine($"My Student: {myStudent.Name} - {myStudent.Age} - {myStudent.Grade}");
        }
    }
}
