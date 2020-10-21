using System;
using System.Collections.Generic;

namespace DataStructuresDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Demo!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(90);
            list.Add(100);
            int index = list.GetIndex(56);
            list.InsertAtParticularPositon(index+1, 99);
            list.Display();
            Console.WriteLine("\nCount of items is : " + list.CountItems());
            list.Pop();
            list.Display();
            Console.WriteLine("\nCount of items is : " + list.CountItems());

            list.PopLast();
            list.Display();
            Console.WriteLine("\nCount of items is : " + list.CountItems());

        }
    }
}
