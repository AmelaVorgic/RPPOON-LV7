using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOONLV7
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider myDataProvider = new SystemDataProvider();
            ConsoleLogger myConsoleLogger = new ConsoleLogger();
            myDataProvider.Attach(myConsoleLogger);

            while (1 < 2)
            {
                myDataProvider.GetCPULoad();
                myDataProvider.GetAvailableRAM();

                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
}
