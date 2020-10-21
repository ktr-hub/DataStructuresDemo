using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    //To create node inside Linked List
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
