using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class OrderedLinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;

                if (head.data.CompareTo(data) >= 0)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    Node tempPrev = head;
                    while (temp != null)
                    {
                        tempPrev = temp;
                        if (temp.data.CompareTo(data) >= 0)
                        {
                            node.next = temp;
                            tempPrev.next = node;
                            break;
                        }
                        temp = temp.next;
                    }
                    if (temp == null)
                    {
                        tempPrev.next = node;
                    }
                }
            }
            Console.WriteLine("Data added "+node.data+" successfully");
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nNo data");
            }
            else
            {
                Console.WriteLine("\nOrdered Linked List Stack : ");
                while (temp.next != null)
                {
                    Console.Write(temp.data+"->");
                    temp = temp.next;
                }
                Console.Write(temp.data);
            }
        }
    }
}
