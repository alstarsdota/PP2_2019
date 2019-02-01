using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1w
{
    class Program
    {
        static bool IsPrime(int a)       //function checks ?the number is prime?
        {
            bool torf = true;
            if (a <= 1)
            {
                torf = false;
                return torf;
            }
         
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        torf = false;
                        return torf;
                    }

                }
            return torf; 

        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());    //input the length of array
            int[] arr = new int[a];             
            string s = Console.ReadLine();       //input the elements of array via row
            string[] ss = s.Split(' ');       //divides every elements of array through space:" "
            for (int i = 0; i < ss.Length; i++)
            {
                arr[i] = int.Parse(ss[i]);  //convert elements in array from string to int
            }
            List<int> vec = new List<int>();    //integer array
            foreach (int z in arr)          //take elements from array by one
            {
                if (IsPrime(z))             //checks the prime of each elements 
                {
                    vec.Add(z);
                }
            }
                string sss =" ";
                Console.WriteLine(vec.ToArray().Length);  // output the length of prime numbers 
                for(int i = 0; i < vec.ToArray().Length; i++)
                {
                    Console.Write(vec[i] + sss);           //output the prime numbers by space:" "
                }
                Console.ReadKey(); //after successing the programm close the console with any key

        }
        }
    }
