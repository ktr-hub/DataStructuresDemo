using System;
using System.Collections.Generic;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Demo!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(90);
            list.Add(100);
            list.InsertAtParticularPositon(3, 99);
            list.Display();
            Console.WriteLine("\nCount of items is : " + list.CountItems());
            list.Pop();
            list.Display();
            Console.WriteLine("\nCount of items is : " + list.CountItems());

        }
    }
}
