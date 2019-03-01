using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    public class Mark
    {
        public string letter;
        public int point;
        public Mark()
        {
        }
        public void Getletter()
        {
            if (90 <= point && point <= 100)
            {
                letter = "A";
            }
            if (76 <= point && point <= 89)
            {
                letter = "B";
            }
            if (60 <= point && point <= 75)
            {
                letter = "C";
            }
        }
        public override string ToString()
        {
            return point + " " + letter;
        }
    }
    class Program
    {
        public static void Serialization(List<Mark> marks)
        {
            FileStream file = new FileStream("tosave.xml", FileMode.Create, FileAccess.ReadWrite);
            XmlSerializer xml = new XmlSerializer(typeof(List<Mark>));
            xml.Serialize(file, marks);
            file.Close();
        }
        public static void Deserialization(List<Mark> Marks)
        {
            FileStream file = new FileStream("tosave.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xml = new XmlSerializer(typeof(List<Mark>));
            Marks = xml.Deserialize(file) as List<Mark>;
            for (int i = 0; i < Marks.ToArray().Length; i++)
            {
                Marks[i].Getletter();
                Console.WriteLine(Marks[i]);
            }
            file.Close();
        }
        static void Main(string[] args)
        {
            List<Mark> marks = new List<Mark>();
            Mark mark = new Mark();
            Console.WriteLine("Enter the mark:");
            mark.point = int.Parse(Console.ReadLine());
            marks.Add(mark);
            List<Mark> marks2 = new List<Mark>();
            Mark mark2 = new Mark();
            Console.WriteLine("Enter the 2nd mark:");
            mark2.point = int.Parse(Console.ReadLine());
            marks.Add(mark2);
            Serialization(marks);
            Deserialization(marks2);
            Console.ReadKey();
        }
    }
}
