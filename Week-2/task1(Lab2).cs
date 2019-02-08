using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3
{
    class Program
    {
        static bool palindrome(string a)        //checks the ?is word palindrome?
        {
            bool t = true;
            for (int i = 0; i < a.Length / 2; i++)
            {
               if(a[i]!= a[a.Length - 1-i])
                { return false; }
            }
            return t; 
            
        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Program Files\Task1\test.txt");//reads the text in file in given path as one word
            
            if (palindrome(text))
            {
                Console.WriteLine("Yes");
            }
            else
            { Console.WriteLine("No"); }
            Console.ReadKey();
        }
    }
}
