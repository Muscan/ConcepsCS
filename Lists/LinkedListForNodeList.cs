using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class LinkedListForNodeList
    {
        NodeList head;
        NodeList tail;

        //constructor
        public LinkedListForNodeList()
        {
            head = null;
            tail = null;
        }

        //insert head

        public void InsertHead(int data)
        {
            NodeList newNode = new NodeList(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        //insert tail       
        
        public void InsertTail(int data)
        {
            NodeList newNode = new NodeList(data);
            //check if the list is empty. 
            //If the list is empty, then the new node is also head and also tail
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        //insert before key

        public void InsertAfterKey(int key, int data)
        {
            NodeList newNode = new NodeList(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                NodeList temp = head;
                while (temp.next != null)
                {
                    if (temp.data == key)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        //insert before key

        public void InsertBeforeKey(int key, int data)
        {
            NodeList newNode = new NodeList(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                NodeList temp = head;
                while (temp.next != null)
                {
                    if (temp.next.data == key)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }


        //delete head
        public void DeleteHead()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                head = head.next;
            }
        }

        //delete tail   
        public void DeleteTail()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                NodeList temp = head;
                while (temp.next != null)
                {
                    if (temp.next.next == null)
                    {
                        temp.next = null;
                        tail = temp;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        //delete node
        public void DeleteNode(int key)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                NodeList temp = head;
                while (temp.next != null)
                {
                    if (temp.next.data == key)
                    {
                        temp.next = temp.next.next;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        //replace key with data
        public void ReplaceKey(int key, int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                NodeList temp = head;
                while (temp.next != null)
                {
                    if (temp.data == key)
                    {
                        temp.data = data;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        //print list

        public void PrintList()
        {
            Console.WriteLine("Linked node list is: ");
            NodeList current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
