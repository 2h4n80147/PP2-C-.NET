using System;
using System.Collections.Generic;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse (Console.ReadLine()); // read the array size
            int [] a = new int [n]; // created an array with n elements
            for (int  i = 0; i < n; i++) {
                a[i] = int.Parse (Console.ReadLine());
            }
            List<int> pr = new List<int>(); // created a list to store a subset with prime numbers
            for (int i = 0; i < n; i++) 
                if (isPrime (a[i])) // a[i] is prime number
                    pr.Add (a[i]); // add to tha back of list pr
            foreach (int x in pr) // iterating over all list
                Console.Write (x.ToString() + " "); // converting numbers to string, and printing them with spaces
        }
        static bool isPrime (int x) { // prime test
            if (x == 1) // corner case
                return false;
            for (int i = 2; i * i <= x; i++) { // iterating over possible divisiors <= sqrt(x)
                if (x % i == 0) // x is divisible by i
                    return false;
                }
            
            // no divisiors were found on range [2..x-1]
            return true;
        }
    }
}
