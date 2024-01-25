using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class PrintScanner
    {
        private readonly IPrinter printer;
        private readonly IScanner scanner;

        public PrintScanner()
        {
            printer = ServiceLocator.Resolve<IPrinter>();
            scanner = ServiceLocator.Resolve<IScanner>();
        }
        
        public void ExecutePrintTask(string path)
        {
            printer.ExecutePrintTask(path);
        }
        public void ExecuteScanTask(string path)
        {
            scanner.ExecuteScanTask(path);
        }
    }
}
