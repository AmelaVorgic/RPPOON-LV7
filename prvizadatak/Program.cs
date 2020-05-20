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
            double[] myArray = new double[] { 72, 11, 65, 3, 9, -36, 14, 100, 0, -84 };
            NumberSequence mySequence = new NumberSequence(myArray);

            BubbleSort myBubble = new BubbleSort();
            mySequence.SetSortStrategy(myBubble);

            Console.WriteLine("Niz koji treba sortirati:\n" + mySequence.ToString());
            mySequence.Sort();
            Console.WriteLine("Sortirani niz:\n " + mySequence.ToString());


        }
    }
}
