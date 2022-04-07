using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class NodeList
    {
        public int data;
        //next is the pointer, which is a reference to the next node
        public NodeList next;
        public NodeList(int d)
        {
            data = d;
            next = null;
        }

        public override string ToString()
        {
            return data.ToString();
        }


    }
}
