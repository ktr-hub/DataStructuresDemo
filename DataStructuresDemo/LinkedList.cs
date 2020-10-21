using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    public class LinkedList
    {
        internal Node head;

        //Adding data into Linked List
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Item Added to Linked List : " + node.data);
        }


        //Viewing data in Linked List
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("No data");
            }
            else
            {
                Console.WriteLine("Linked list items : ");
                while(temp!=null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }

    }
}
