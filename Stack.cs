using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue_UsingLinkedList
{
    public class Stack
    {
        class Node
        {
            public int data;
            public Node next;
        }
        Node head;
        public void push(int x)
        {
            Node temp = new Node();
            temp.data = x;
            temp.next = head;
            head = temp;
        }
        public void Display()
        {

            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data);
                temp = temp.next;
                if (temp != null)
                {
                    Console.Write("->");
                }
            }


        }
    }
}
