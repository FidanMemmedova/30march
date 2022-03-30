using System;
using System.Collections.Generic;
using System.Text;

namespace _30march
{
    class Student
    {
        public int Id { get; }
        public static int id;
        public string Name;
        public string Surname;
        public int Age;
        public int Point;
        public bool Created = false;
        public Student(string name, string surname, int point)
        {
            Name = name;
            Surname = surname;
            Point = point;
            id++;
            Id = id;
        }
        public Student(string name, string surname, int age, int point):this(name,surname,point)
        {
            Age = age;
           
        }
        public void ShowInfo()
        {
            Console.WriteLine("name: " + Name + " surname: " + Surname + " age: " + Age + " point: " + Point);

        }
    }
}
