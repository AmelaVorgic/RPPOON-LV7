using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOONLV7
{
    class PriceCalculatingVisitor : IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
                return Double.NaN;
            return DVDItem.Price * 0.1;
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * 0.1;
        }
        public double Visit(Book BookItem)
        {
            return BookItem.Price * 0.1;
        }

    }
}
