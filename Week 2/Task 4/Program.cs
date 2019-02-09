using System;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo path1 = new DirectoryInfo (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 4\source folder");
            DirectoryInfo path2 = new DirectoryInfo (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 4\destination");

            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.WriteLine ("BEFORE");
            // Console.ForegroundColor = ConsoleColor.White;


            // show (path1);
            // show (path2);
            
            // Console.WriteLine ("Enter the file name");
            string afile = Console.ReadLine();
            
            string sfile = Path.Combine(path1.FullName, afile);
            string ffile =  Path.Combine(path2.FullName, afile);
            if (!File.Exists (sfile)) {

                Console.WriteLine ("File was not found, new instnace was created");
                File.WriteAllText (sfile, afile + " was created");
            }
            Console.WriteLine ("Moving a file \n From {0}\n To {1}", sfile, ffile);
            File.Move (sfile, ffile);
            Console.WriteLine ("Moving completed.");
            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine ("AFTER");
            //Console.ForegroundColor = ConsoleColor.White;

            // show (path1);
            // show (path2);
        }
        static void show (DirectoryInfo x) {
            Console.WriteLine (x.FullName);
            var files = x.GetFileSystemInfos();
            
            foreach (var i in files) {
                Console.WriteLine("    " + i.Name);
            }
        }
    }
}
