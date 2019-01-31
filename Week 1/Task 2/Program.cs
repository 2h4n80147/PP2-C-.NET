using System;

namespace Task_2
{
    class Student {
        string name;
        string id;
        int year;

        public Student(string name, string id) {
            this.name = name;
            this.id = id;
            this.year = 0;
        }
        public void getName() {
            Console.WriteLine ("Name: " + name);
        }
        public void getId() {
            Console.WriteLine ("Id: " + id);
        }
        public void incYear () {
            year++;
        }
        public void  getYear  () {
            Console.WriteLine ("Year: " + year.ToString());
        }
        public void PrintInfo() {
            getName();
            getId();
            getYear();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student ("Jigurda", "18BD7777777");
            s1.incYear();
            s1.PrintInfo();
            s1.incYear();
            s1.PrintInfo();
        }
    }
}
