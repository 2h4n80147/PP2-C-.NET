using System;
using System.IO;

namespace sat.sh.task
{
    class Program
    {
        class aclass {
            string text;
            public aclass (string t) {
                text = t;
            }
            public string format () {
                string res = "";
                foreach (char c in text) {
                    if (c == 'a' || c == 'o' || c == 'e' || c == 'i' || c == 'u')
                        continue;
                    res = res + c;
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            aclass a = new aclass (s);
            StreamWriter output = new StreamWriter(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Test\sat.sh.task\something");
            output.Write(a.format());
            output.Close();
        }
    }
}
