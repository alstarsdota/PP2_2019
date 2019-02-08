using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W3
{
    class Program
    {
        static string Spaces(int a)                       //for the spaces
        {
            string s = "      ";
            string q = "";
            for (int i = 0; i < a; i++)
            {
                q=q+s;
            }
            return q;
        }
        static void Paths(DirectoryInfo dir, int a)   //recursion for the open the folders and write the name of them
        {
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dires = dir.GetDirectories();
            foreach (FileInfo file in files)          //write files name with some space on the front
            {
                Console.Write(Spaces(a));
                Console.WriteLine(file.Name);

            }
            foreach (DirectoryInfo dire in dires)       //write folders name with some space on the front
            {
                Console.Write(Spaces(a));
                Console.WriteLine(dire.Name);
                
                Paths(dire, a + 1); 
            }
            
           
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\MAIN SITE");
            Paths(dir, 0);
            Console.ReadKey();
        }
    }
}