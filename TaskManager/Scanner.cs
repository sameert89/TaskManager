using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Scanner : IScanner
    {
        public void ExecuteScanTask(string path)
        {
            System.Console.WriteLine($"Scanning .....{path}");
        }
    }
}
