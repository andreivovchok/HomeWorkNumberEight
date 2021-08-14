using System;
using System.Collections.Generic;
using HomeWorkNumberEight;

namespace PrinterConsoleAppcation
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello";

            Printer printer = new Printer();

            GreenPrinter greenPrinter = new GreenPrinter();

            BluePrinter bluePrinter = new BluePrinter();

            Room room = new Room(printer);
            room.MakeThisLazyPrinterWork(test);

            room.SetNewPrinter(greenPrinter);
            room.MakeThisLazyPrinterWork(test);

            room.SetNewPrinter(bluePrinter);
            room.MakeThisLazyPrinterWork(test);
        }
    }
}
