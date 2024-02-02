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
        public static Student[] myStudents = new Student[4];
        static void Main(string[] args)
        {
            Student myStudent1 = new Student(0, "Nguyễn Văn A", 10, "5D4");
            Student myStudent2 = new Student(1, "Nguyễn Văn B", 9, "4C3");
            Student myStudent3 = new Student(2, "Nguyễn Văn C", 8, "3B2");
            Student myStudent4 = new Student(3, "Nguyễn Văn D", 7, "2A1");
            myStudents[0] = myStudent1;
            myStudents[1] = myStudent2;
            myStudents[2] = myStudent3;
            myStudents[3] = myStudent4;

            //1. Create Student LinkedList
            LinkedList<Student> studentList = new LinkedList<Student>();
            //2. Add student in LinkedList
            studentList.AddLast(myStudent1);
            studentList.AddLast(myStudent2);
            studentList.AddLast(myStudent3);
            studentList.AddLast(myStudent4);
            //3. Show first student
            Console.WriteLine("\nFirst student:");
            ShowInfo(studentList.First.Value);
            //4. Show last student
            Console.WriteLine("\nLast student:");
            ShowInfo(studentList.Last.Value);
            //5.
            Console.WriteLine("\nShow all student:");
            ShowAllStudentInLinkedList(studentList);
            //6.
            Student searchNameStudent = SearchNameLinkedList(studentList, "Nguyễn Văn A");
            if (searchNameStudent != null)
            {
                Console.WriteLine("\nSearch student name:");
                ShowInfo(searchNameStudent);
            }
            else
                Console.WriteLine("No result");
            //7.
            Student searchhighestAge = SearchAgeLinkedList(studentList, true);
            ShowInfo(searchhighestAge);
            //8.
            Student searchlowestAge = SearchAgeLinkedList(studentList, false);
            ShowInfo(searchlowestAge);
            //9.
            ChangePositionStudentLinkedList(studentList, 3);
        }

        private static void ChangePositionStudentLinkedList(LinkedList<Student> studentList, int newPos)
        {
            Student tempStudent = studentList.First.Value;
            Student valueNewPos = studentList.First.Value;
            LinkedListNode<Student> p = studentList.First;
            for (int i = 0; i < newPos; i++)
            {
                p = p.Next;
                if (i == newPos - 1)
                {
                    valueNewPos = p.Value;
                    p.Value = tempStudent;
                }
            }
            studentList.First.Value = valueNewPos;

            Console.WriteLine("\nChange position students: ");
            ShowAllStudentInLinkedList(studentList);
        }

        private static void ShowInfo(Student student)
        {
            Console.WriteLine($"Position: {student.Positon} - Name: {student.Name} - Age: {student.Age} - Class: {student.Grade}");
        }

        private static Student SearchAgeLinkedList(LinkedList<Student> studentList, bool isHighest)
        {
            LinkedListNode<Student> indexNode = studentList.First;
            int tempAge = studentList.First.Value.Age;
            for (LinkedListNode<Student> p = studentList.First; p != null; p = p.Next)
            {
                if (isHighest)
                {
                    if (tempAge < p.Value.Age)
                    {
                        tempAge = p.Value.Age;
                        indexNode = p;
                    }
                }
                else
                {
                    if (tempAge > p.Value.Age)
                    {
                        tempAge = p.Value.Age;
                        indexNode = p;
                    }
                }
            }

            Console.WriteLine($"\nSearch {(isHighest ? "highest" : "lowest")} age student:");
            return indexNode.Value;
        }

        private static Student SearchNameLinkedList(LinkedList<Student> studentList, string nameSearch)
        {
            Student temp = null;
            foreach (Student student in studentList)
            {
                if (student.Name == nameSearch)
                {
                    temp = student;
                }
            }
            return temp;
        }

        private static void ShowAllStudentInLinkedList(LinkedList<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                ShowInfo(student);
            }
        }
    }
}