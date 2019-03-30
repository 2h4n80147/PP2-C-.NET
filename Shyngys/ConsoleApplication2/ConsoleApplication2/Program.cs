using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

	[Serializable]
	public class Student {
		public string name, surname, id, yearOfStudy;
		public string []disciplines;
		public Student(string name, string surname, string id, string yearOfStudy, string []disciplines) {
			this.name = name;
			this.surname = surname;
			this.id = id;
			this.yearOfStudy = yearOfStudy;
			this.disciplines = disciplines;
		}
		public string to_string()
		{
			string res = name + " " + surname + " " + id + " " + yearOfStudy;
			for (int i = 0; i < disciplines.Length; i++)
				res += disciplines[i] + " ";
			return res;
		}
	}

	[Serializable]
	public class Teacher
	{
		public string name, surname, email, tel, discipline;
		public Teacher() { }
		public Teacher (string name, string surname, string email, string tel, string discipline)
		{
			this.name = name;
			this.surname = surname;
			this.email = email;
			this.tel = tel;
			this.discipline = discipline;
		}
		public string to_string()
		{
			string res = name + " " + surname + " " + email + " " + tel + " " + discipline;
			return res;
		}
	}
	[Serializable]
	public class Group
	{
		public Student s;
		public Teacher t;
		public string time;
		public Group() {
		}
		public Group (Student s, Teacher t, string time)
		{
			this.s = s;
			this.t = t;
			this.time = time;
		}
		public string to_string()
		{
			return s.to_string() + " " + t.to_string() + " " + time;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int c = Console.Read();
			if (c == '0')
			{
				store();
				Console.Write("stored");
			}
			else
			{
				restore();
			}

		}
		static void restore()
		{
			FileStream W = new FileStream(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Shyngys\ConsoleApplication2\ConsoleApplication2\info.bin", FileMode.Open, FileAccess.Read); // read a serialized file
			BinaryFormatter formatter = new BinaryFormatter(); // create binary formatter tool
			Group g = formatter.Deserialize(W) as Group;
			Console.WriteLine(g.to_string());
			Console.ReadKey();
			W.Close(); // close serialized file
		}
		static void store()
		{
			Group g = new Group(new Student("AKka", "bakka", "0300", "01", new string[] { "Math", "Computer Science" }), new Teacher("Aken", "Mol", "bba@bab", "+7 777", "Math"), "16:00");

			FileStream W = new FileStream(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Shyngys\ConsoleApplication2\ConsoleApplication2\info.bin", FileMode.OpenOrCreate, FileAccess.Write);
			// opens a file stream for serialized list

			BinaryFormatter formatter = new BinaryFormatter(); // create a tool for binary formatting
			formatter.Serialize(W, g); // serialize the list to grades.bin file in the current directory
			W.Close(); // close the fil
		}
	}
}
