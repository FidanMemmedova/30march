using System;

namespace _30march
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Fidan = new Student("Fidan", "Mammadova", 20, 55);
            Student Ali = new Student("Ali", "Valiyev", 19, 25);
            Fidan.ShowInfo();
            Ali.ShowInfo();
            Console.WriteLine(Fidan.Id);
            Console.WriteLine(Ali.Id);
            Group Code = new Group();
            Console.WriteLine(Code.GroupName);
            Group Code2 = new Group();
            Console.WriteLine(Code2.GroupName);
        }
    }
}
