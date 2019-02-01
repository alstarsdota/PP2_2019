using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        class student
        {
            public string name; //name of student
            public string id;   //id of student
            public int year;    //year of studying of student
            public student(string n, string ii)    //constructure with two parameters 
            {
                name = n;
                id = ii;
            }
            public void increment()    //Method to increment the year of studying of student 
            {
                year++;
            }    
            public void NameAndId()    //Method to access increment name and id of student
            {
                Console.Write(name+" "+id+" ");
            }
        }
        static void Main(string[] args)
        {
            student a = new student("Koblan", "18BD123456");
            a.year = 1;                 //default value of year
            a.increment();              //use the method of increment
            a.NameAndId();              //use the method of nameandid
            Console.WriteLine(a.year);   
            Console.ReadKey();          //after successing the programm close the console with any key
        }
    }
}
