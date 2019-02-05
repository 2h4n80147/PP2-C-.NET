using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 1\input1");
            StreamWriter output = new StreamWriter(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 1\output1");
            
            string s;

            while ( (s = input.ReadLine()) != null) {
                output.WriteLine( s + " " + (palindrome(s) ? "YES" : "NO"));
            }
            input.Close();
            output.Close();
        }
        static bool palindrome (string s) {
            for (int i = 0; i < s.Length/2; i++)
                if (s[i] != s[s.Length-1-i])
                    return false;
            return true;
        }
    }
}
