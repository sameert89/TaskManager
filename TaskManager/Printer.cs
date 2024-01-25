using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Printer : IPrinter
    {
        public void ExecutePrintTask(string path)
        {
            System.Console.WriteLine($"Printing .....{path}");
        }
    }
}
