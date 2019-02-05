using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 2\input1");
            StreamWriter output = new StreamWriter (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 2\output1", true);
            string x;
            while ((x = input.ReadLine()) != null) {
                if (IsPrime(int.Parse(x))) {
                    output.WriteLine (x);
                }
            }
            input.Close();
            output.Close();
        }
        static bool IsPrime (int x) {
            if (x == 1)
                return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
    }
}
