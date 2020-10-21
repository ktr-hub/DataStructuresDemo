﻿using System;
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

        //Adding data in between nodes
        internal void InsertAtParticularPositon(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            else if (position == 1)
            {
                var newNode = new Node(data);
                //Adding node at beginning
                newNode.next = this.head;

                //Assigning head to the new node as it became first data
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                    }
                    temp = temp.next;
                }
            }
        }

        //Get Count of items inside LinkedList
        internal int CountItems()
        {
            Node temp = this.head;
            if (temp == null)
            {
                return 0;
            }
            else
            {
                int count = 0;
                while (temp != null)
                {
                    temp = temp.next;
                    count++;
                }
                return count;
            }
        }

        //Viewing data in Linked List
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nNo data");
            }
            else
            {
                Console.WriteLine("\nLinked list items : ");
                while(temp!=null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }

        //Popping start element UC-5 
        internal void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("\nNo data to pop");
            }
            else
            {
                Console.WriteLine("\nDeleting the first Data : " + this.head.data);
                this.head = this.head.next;
            }
        }

        //Popping start element UC-6
        internal void PopLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("\nNo data to pop");
            }
            else
            {
                Node tempPrev = head;
                Node temp = head;
                //If only head is the last node
                if (temp.next == null)
                {
                    Console.WriteLine("\nDeleting the Last Data: " + temp.data);
                    head = null;
                }
                else
                {
                    while (temp.next != null)
                    {
                        tempPrev = temp;
                        temp = temp.next;
                    }
                    Console.WriteLine("\nDeleting the Last Data: " + temp.data);
                    tempPrev.next = null;
                }
            }
        }

    }
}
