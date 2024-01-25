﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Program
    {
        static void Main()
        {
            
            Printer printerObj = new Printer();
            Scanner scannerObj = new Scanner();
            ServiceLocator.Register<IPrinter>(printerObj);
            ServiceLocator.Register<IScanner>(scannerObj);

            PrintScanner printScannerObj = new PrintScanner();

            TaskManager.ExecutePrintTask(printerObj, "Test.doc");
            TaskManager.ExecuteScanTask(scannerObj, "MyImage.png");
            TaskManager.ExecutePrintTask(printScannerObj, "NewDoc.doc");
            TaskManager.ExecuteScanTask(printScannerObj, "YourImage.png");

            Console.ReadLine();
        }
    }
}
