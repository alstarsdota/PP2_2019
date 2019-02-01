using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Twotimes(int[] ar, int[] arr)     //crete the static method to repeting the elements of array
        {
            for (int i = 0; i < ar.Length; i++)
            {
                arr[2 * i] = ar[i];
                arr[2 * i + 1] = ar[i];
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());   //input the length of array
            string s = Console.ReadLine();           //input the elements of array via row
            string[] ss = s.Split(' ');              //divides every elements of array through space:" "
            int[] ar2 = new int[2 * a];              //two times larger array than first array 
            int[] ar1 = new int[a];                  //first array
            for(int i = 0; i < ss.Length; i++)
            {
                ar1[i] = int.Parse(ss[i]);
            }
            Twotimes(ar1, ar2);                       //call the method "Twotimes"
            for (int i = 0; i <ar2.Length; i++)
            {
                Console.Write(ar2[i] + " ");          //output the two times repeated elements
            }
            Console.ReadKey(); //after successing the programm close the console with any key
        }
    }
}
