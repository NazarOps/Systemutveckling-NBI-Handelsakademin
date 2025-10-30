using System;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GenericPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //           Skapa en generisk metod PrintItems<T>(List < T > items) som skriver ut alla element oavsett typ.
            //💡 Testa med listor av string, int och double.


            Printer printer = new Printer();
            printer.AddItems();

            printer.PrintItems(printer.listofstrings);
            printer.PrintItems(printer.listofints);
            printer.PrintItems(printer.listofdoubles);
        }
    }
}
