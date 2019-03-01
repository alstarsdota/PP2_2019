using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6
{
    public class Complex
    {
        public int a;
        public int b;
        public void Write()
        {
            Console.Write(a+"+"+b+"*i");
        }
        public Complex()
        {
        }
    }
    class Program
    {
        public static void Serialization(Complex compl)
        {
            FileStream fs = new FileStream("tosave.xml", FileMode.Create, FileAccess.ReadWrite);
            XmlSerializer xmls = new XmlSerializer(typeof(Complex));
            xmls.Serialize(fs, compl);
            fs.Close();
        }

        public static void Deserialization(Complex compl)
        {
            FileStream fs = new FileStream("tosave.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xmls = new XmlSerializer(typeof(Complex));
            compl = xmls.Deserialize(fs) as Complex;
            compl.Write();
        }

        static void Main(string[] args)
        {
            Complex complex = new Complex();
            complex.a = int.Parse(Console.ReadLine());
            complex.b = int.Parse(Console.ReadLine());
            Serialization(complex);
            Complex complex2 = new Complex();
            Deserialization(complex2);
            Console.ReadKey();
        }
    }
}
