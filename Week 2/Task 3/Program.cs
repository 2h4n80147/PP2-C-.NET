using System;
using System.IO;

namespace Task_3
{
    public class Program
    {
        static void Main()
        {
            DirectoryInfo root = new DirectoryInfo (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU");
            file_tree (root, 0);
        }
        static void file_tree (DirectoryInfo root, int lvl) {
            var files = root.GetFiles();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var i in files) {
                for (int j = 0; j < 4*lvl; j++)
                    Console.Write (' ');

                Console.WriteLine (i.Name);
                
            }
            var subdirs = root.GetDirectories();
            foreach (var i in subdirs) {
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < 4*lvl; j++)
                {
                    Console.Write (" ");
                }
                Console.WriteLine(i.Name);
                file_tree (i, lvl + 1);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
