using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOONLV7
{
    class Cart
    {
        private List<IItem> list;
        IVisitor visitor;
        public Cart() { list = new List<IItem>(); }
        public void SetVisitor(IVisitor visitor)
        {
            this.visitor = visitor;
        }
        public void AddItem(IItem item)
        {
            list.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            list.Remove(item);
        }
        public double Accept(IVisitor visitor)
        {
            double temp = 0;
            foreach (IItem item in list)
            {
                temp += item.Accept(visitor);
            }
            return temp;
        }
    }
}
