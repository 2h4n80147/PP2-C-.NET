using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task1
{
	public class Author
	{
		public string name;
		public string surname;
		public int age;
		public Author (string a, string b, int c)
		{
			name = a;
			surname = b;
			age = c;
		}
		public Author() { }
		public string toString2()
		{
			return name + " " + surname + " " + age;
		}

	}
	public class Post
	{
		public Author author;
		public DateTime date;
		public string text;
		public Post(Author a, DateTime d, string t)
		{
			author = a;
			date = d;
			text = t;
		}
		public Post() { }
		public string toString()
		{
			return author.toString2() + " " + date.ToString() + " " + text;
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
				Console.WriteLine("Stored!");
			}
			else
			{
				restore();
				Console.ReadKey();
			}
		}
		static void store() { 
			Post A = new Post(new Author("Abay", "Kunanbay", 35), new DateTime(1900, 7, 20, 18, 30, 25), "Kara soz");
			Post B = new Post(new Author("Green", "Kunanbay", 35), new DateTime(1800, 7, 20, 18, 30, 25), "Hello");
			Post C = new Post(new Author("Lenin", "Kunanbay", 35), new DateTime(2000, 7, 20, 18, 30, 25), "Krasota");
			List<Post> L = new List<Post>();
			L.Add(A);
			L.Add(B);
			L.Add(C);
			XmlSerializer X = new XmlSerializer(typeof(List<Post>));
			FileStream file = new FileStream(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Quiz\task1\task1\info.xml", FileMode.OpenOrCreate, FileAccess.Write);
			X.Serialize(file, L);
			file.Close();
		}
		static void restore()
		{
			XmlSerializer X = new XmlSerializer(typeof(List<Post>));
			FileStream file = new FileStream(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Quiz\task1\task1\info.xml", FileMode.OpenOrCreate, FileAccess.Read);
			List<Post> L2 = X.Deserialize(file) as List<Post>;
			for (int i = 0; i < L2.Count; i++)
				Console.WriteLine(L2[i].toString());
			file.Close();

		}
	}
}
