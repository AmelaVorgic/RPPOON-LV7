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
            Book Thriller = new Book("Gone Girl", 16.39);
            DVD Horror = new DVD("IT", DVDType.MOVIE, 18.89);
            VHS Cartoon = new VHS("Snowwhite", 13.23);

            Console.WriteLine("You want \n" + Thriller.ToString() + "\nPrice for your order is:" + Thriller.Accept(Customer));

        }
    }
}
