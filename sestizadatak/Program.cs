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
            BuyVisitor Customer = new BuyVisitor();
            PriceCalculatingVisitor Buyer = new PriceCalculatingVisitor();

            Book Thriller = new Book("Gone Girl", 16.39);
            DVD OperatingSystem = new DVD("Windows 10", DVDType.SOFTWARE, 99.99);
            VHS Cartoon = new VHS("Snowwhite", 13.23);

            Console.WriteLine(OperatingSystem.Accept(Buyer));

        }
    }
}
