using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class DoubleNodeList
    {
        public int data;

        public DoubleNodeList nextNode;

        public DoubleNodeList prevNode;

        public DoubleNodeList(int data)
        {
            this.data = data;
            this.nextNode = null;
            this.prevNode = null;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
