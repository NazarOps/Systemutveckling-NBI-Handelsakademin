using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrinter
{
    public class Printer
    {
        List<string> listofstrings = new List<string>();
        List<int> listofints = new List<int>();
        List<double> listofdoubles = new List<double>();





        public static void PrintItems<T>(List<T> items)
        {
            foreach (var thing in items)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
