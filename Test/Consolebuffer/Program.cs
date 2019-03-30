using System;
using System.IO;
using System.Collections.Generic;

namespace Consolebuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.SetWindowsSize(20, 20);
            Console.SetBufferSize(20, 20);
            int n = 20;
            for (int i = 1; i <= 20; i++) {
                int x = rand.Next()%n;
                int y = rand.Next()%n;
                Console.SetCursorPosition(x, y);
                Console.Write("S");
            }
        }
    }
}   
