using System;

namespace HomeWorkNumberEight
{
    public class BluePrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
            Console.ResetColor();
        }
    }
}
