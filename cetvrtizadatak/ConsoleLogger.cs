using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOONLV7
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine(DateTime.Now + " CPU load: " +
            provider.CPULoad + ", available RAM: " + provider.AvailableRAM);
        }
    }
}
