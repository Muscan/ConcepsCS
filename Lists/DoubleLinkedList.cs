using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class DoubleLinkedList
    {
        private DoubleNodeList head;
        private DoubleNodeList tail;

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
        }

        public void InsertHead(int data)
        {
            DoubleNodeList newNode = new DoubleNodeList(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.nextNode = head;
                head.prevNode = newNode;
                head = newNode;
            }
        }

        public void InsertTail(int data)
        {
            DoubleNodeList newNode = new DoubleNodeList(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.prevNode = tail;
                tail.nextNode = newNode;
                tail = newNode;
            }
        }

        public void RemoveFromHead()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.nextNode;
                head.prevNode = null;
            }
        }

        public void RemoveFromTail()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prevNode;
                tail.nextNode = null;
            }
        }

        public void InsertBeforeKey(int key, int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            DoubleNodeList current = head;
            while (current != null)
            {
                if (current.data == key)
                {
                    DoubleNodeList newNode = new DoubleNodeList(data);
                    newNode.nextNode = current;
                    newNode.prevNode = current.prevNode;
                    current.prevNode.nextNode = newNode;
                    current.prevNode = newNode;
                    return;
                }
                current = current.nextNode;
            }
            Console.WriteLine("Key not found");
        }

        //insert after key

        public void InsertAfterKey(int key, int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            DoubleNodeList current = head;
            while (current != null)
            {
                if (current.data == key)
                {
                    DoubleNodeList newNode = new DoubleNodeList(data);
                    newNode.prevNode = current;
                    newNode.nextNode = current.nextNode;
                    current.nextNode.prevNode = newNode;
                    current.nextNode = newNode;
                    return;
                }
                current = current.nextNode;
            }
            Console.WriteLine("Key not found");
        }
        public void PrintList()
        {
            DoubleNodeList current = head;
            while (current != null)
            {
                Console.Write(current + " ");
                current = current.nextNode;
            }
            Console.WriteLine();
        }

        public void ReversePrintList()
        {
            DoubleNodeList current = tail;
            while (current != null)
            {
                Console.Write(current + " ");
                current = current.prevNode;
            }
            Console.WriteLine();
        }
    }
}
