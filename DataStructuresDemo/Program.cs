using System;
using System.Collections.Generic;

namespace DataStructuresDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderedLinkedList orderedLinkedList = new OrderedLinkedList();
            orderedLinkedList.Add(56);
            orderedLinkedList.Add(40);
            orderedLinkedList.Add(70);
            orderedLinkedList.Add(10);
            orderedLinkedList.Display();
        }
    }
}
