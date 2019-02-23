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
                subject = a;
                grade = b;
            }

            static string [] letter = {"A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F"}; 
            static int [] cutof = {95, 90, 85, 80, 75, 70, 65, 60, 55, 50, 0};
            string getLetter () {
                double g = double.Parse(grade, CultureInfo.InvariantCulture);
                for (int i = 0; i < cutof.Length; i++)
                    if (g >= cutof[i])
                        return letter[i];
                return letter[letter.Length-1];
            }
            public string toString() {
                return subject + " - " + grade + ", " + getLetter();
            }
        }
    class Program
    {
 
        static void Main(string[] args)
        {

            store();
            
        }
        static void restore () {
            FileStream W = new FileStream (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 5\Task 2\grades.bin" ,FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Mark> A = (List<Mark>)formatter.Deserialize (W);
            foreach (Mark x in A)
                Console.WriteLine(x.toString());
            W.Close();
        }
        static void store() {
            //Mark x = new Mark ("jkldsja", "something");
            List<Mark> A = new List<Mark>();
            A.Add (new Mark("Programming Principles", "94.5"));
            A.Add (new Mark("English", "55.0"));

        
            FileStream W = new FileStream (@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 5\Task 2\grades.bin" ,FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize (W, A);
            W.Close();
        }
    }
}
