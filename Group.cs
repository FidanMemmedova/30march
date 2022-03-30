using System;
using System.Collections.Generic;
using System.Text;

namespace _30march
{
    class Group
    {
        public int No { get; }
        public static int no = 200;
        public string GroupName;
        public Student[] Student;
        public Group(params Student[] student)
        {
            no++;
            No = no;
            GroupName = $"BP{No}";
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Student, Student.Length + 1);
            Student[^1] = student;
        }
        public void GetAllStudents()
        {
            foreach (Student students in Student)
            {
                Console.WriteLine(students);
            }
        }
        public void Sort()
        {
            Student temp;
            for (int i = 0; i < Student.Length - 1; i++)
            {
                for (int j = 0; j < Student.Length-1; j++)
                {
                    if (Student[j].Point > Student[j + 1].Point)
                    {
                        temp = Student[j];
                        Student[j] = Student[j + 1];
                        Student[j + 1] = temp;
                    }
                }
            }
        }
    }
}
