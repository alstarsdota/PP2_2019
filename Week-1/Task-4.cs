using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());   //input the number
            string s = "[*]";                        //assign the "[*]" to the string 's'
            for(int i=1;i<=a;i++)
            {for (int j = 1; j <= i; j++)
                {
                    Console.Write(s);                //output the increasing the number of "[*]" and column, respectively
                }
                Console.WriteLine();                 //write to next row
            }
            Console.ReadKey();        ////after successing the programm close the console with any key
        }
    }
}
