using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrinter
{
    public class Printer
    {
        public List<string> listofstrings = new List<string>();
        public List<int> listofints = new List<int>();
        public List<double> listofdoubles = new List<double>();

        

        public void AddItems()
        {
            listofstrings.Add("string 1");
            listofstrings.Add("string 2");
            listofstrings.Add("string 3");

            listofints.Add(1);
            listofints.Add(2);
            listofints.Add(3);

            listofdoubles.Add(1.5);
            listofdoubles.Add(1.3);
            listofdoubles.Add(1.93);
        }

        // static can only be called inside the class
        public void PrintItems<T>(List<T> items)
        {
            foreach (var thing in items)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
