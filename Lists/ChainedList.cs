using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class ChainedList
    {
        //declare a variable of type Node
        private List<int> Head { get; set; }
        private List<int> Tail { get; set; }

        public ChainedList()
        {
            Head = new List<int>();
            Tail = new List<int>();
        }

        public void Add(int value)
        {
            if (Head.Count == 0)
            {
                Head.Add(value);
            }
            else
            {
                Tail.Add(value);
            }
        }

        public void Print()
        {
            Console.WriteLine("Head: ");
            foreach (var item in Head)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Tail: ");
            foreach (var item in Tail)
            {
                Console.WriteLine(item);
            }
        }

        public void Reverse()
        {
            if (Head.Count == 0)
            {
                return;
            }
            else
            {
                Tail.Add(Head[0]);
                Head.RemoveAt(0);
                Reverse();
            }
        }

        public void RemoveAt(int v)
        {
            if (Head.Count == 0)
            {
                return;
            }
            else
            {
                Tail.Add(Head[0]);
                Head.RemoveAt(0);
                RemoveAt(v);
            }
            
        }

        public void ReplaceAt(int v)
        {
            if (Head.Count == 0)
            {
                return;
            }
            else
            {
                Tail.Add(Head[0]);
                Head.RemoveAt(0);
                ReplaceAt(v);
            }
        }
        //print

       
    }
}
