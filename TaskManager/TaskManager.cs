using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public static class TaskManager
    {
        public static void ExecutePrintTask(object obj, string path)
        {
            Type t = obj.GetType();
            var methodInfo = t.GetMethod("ExecutePrintTask", BindingFlags.Public);

            methodInfo?.Invoke(obj, new object[] { path });
        }
       public static void ExecuteScanTask(object obj, string path)
        {
            Type t = obj.GetType();
            var methodInfo = t.GetMethod("ExecuteScanTask", BindingFlags.Public);
            methodInfo?.Invoke(obj, new object[] { path });
        }
 
    }

}
