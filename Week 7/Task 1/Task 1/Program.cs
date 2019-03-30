using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_1
{
  class Program
  {
    static void Main(string[] args)
    {
      //a.Start();
      Thread[] T = new Thread[3];
      for (int i = 0; i < 3; i++)
      {
        T[i] = new Thread(print);
        T[i] = new Thread(new ThreadStart(print));
        T[i].Name = "Threader " + i.ToString();
      }
      for (int i = 0; i < 3; i++)
      {
        T[i].Start(); 
      }
      Console.Read();
    }
    static void print()
    {
      Console.WriteLine(Thread.CurrentThread.Name + " is threading here ");
    }
  }
}
