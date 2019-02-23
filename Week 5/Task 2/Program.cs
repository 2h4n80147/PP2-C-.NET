using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Globalization;

namespace Task_2
{
        [Serializable]
        class Mark {
            public string subject;  // subject name
            public string grade; // percentage grade
            public Mark (string a, string b) {
                // initializing values
                subject = a;
                grade = b;
            }

            // list of letters for grades
            static string [] letter = {"A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F"}; 
            
            // list of cutoffs points for grade letter marks
            static int [] cutof = {95, 90, 85, 80, 75, 70, 65, 60, 55, 50, 0}; 
            string getLetter () {  // returns letter mark
                double g = double.Parse(grade, CultureInfo.InvariantCulture); // convert grade to double
                for (int i = 0; i < cutof.Length; i++) // iterate through letter marks and look for first lowerbound of our percentage
                    if (g >= cutof[i]) // if it's above the cutoff
                        return letter[i]; // return attached letter
                return letter[letter.Length-1]; // return F otherwise
            }
            public string toString() {
                return subject + " - " + grade + ", " + getLetter(); // return a string in the format -> subject - grade in points, grade in a letter
            }
        }
    class Program
    {
 
        static void Main(string[] args)
        {

            store(); // serialize or deserialzie
            
        }
        static void restore () {
            FileStream W = new FileStream (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 5\Task 2\grades.bin" ,FileMode.Open, FileAccess.Read); // read a serialized file
            BinaryFormatter formatter = new BinaryFormatter(); // create binary formatter tool
            List<Mark> A = (List<Mark>)formatter.Deserialize (W); // deseralize the file as list of marks
            foreach (Mark x in A)  /// iterate over marks
                Console.WriteLine(x.toString()); // print information about marks
            W.Close(); // close serialized file
        }
        static void store() {
            List<Mark> A = new List<Mark>(); // list of marks
            A.Add (new Mark("Programming Principles", "94.5")); // add first subject
            A.Add (new Mark("English", "55.0")); // add second subject

        
            FileStream W = new FileStream (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 5\Task 2\grades.bin" ,FileMode.Create, FileAccess.Write);
            // opens a file stream for serialized list

            BinaryFormatter formatter = new BinaryFormatter(); // create a tool for binary formatting
            formatter.Serialize (W, A); // serialize the list to grades.bin file in the current directory
            W.Close(); // close the fil
        }
    }
}
