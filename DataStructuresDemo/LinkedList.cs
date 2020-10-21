using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    public class LinkedList
    {
        internal Node head;

        //Adding data into Linked List
        public void Add(int data)
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

        //Deleting data 
        public void Remove(int data)
        {
            Node temp = head;
            Node tempPrev = head;
            bool dataFound = false;
            if (head.data == data)
            {
                Console.WriteLine("\nDeleting data : " + head.data);
                dataFound = true;
                head = head.next;
            }
            else {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Console.WriteLine("\nDeleting data : " + temp.data);
                        tempPrev.next = tempPrev.next.next;
                        dataFound = true;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (dataFound == false)
            {
                Console.WriteLine("No data found");
            }
        }


        //Adding data in between nodes
        public void InsertAtParticularPositon(int position, int data)
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
            else if (position > this.CountItems()+1)
            {
                Console.WriteLine("Invalid position");
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
        public int CountItems()
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

        //To get index of first occurrence of a specific data in the linked list
        public int GetIndex(int data)
        {
            if (head == null)
            {
                return -1;
            }
            else
            {
                int count = 1;
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        return count;
                    }
                    count++;
                    temp = temp.next;
                }
                return -1;
            }
        }

        //Popping start element UC-6
        internal void PopLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("\nNo data to pop");
            }
            //If only head is the last node
            else if (head.next == null)
            {
                Console.WriteLine("\nDeleting the Last Data: " + head.data);
                head = null;
            }
            else
            {
                Node tempPrev = head;
                Node temp = head;

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
