using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkNumberEight
{
    public class Room
    {
        Printer _printer;

        public Room (Printer printer)
        {
            _printer = printer;
        }

        public void MakeThisLazyPrinterWork(string value)
        {
            _printer.Print(value);
        }

        public void SetNewPrinter(Printer printer)
        {
            _printer = printer;
        }
    }
}
