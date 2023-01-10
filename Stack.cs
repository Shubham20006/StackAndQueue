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
        public void pop()
        {
            if (head == null)
            {
                Console.Write("Stack is empty");
                return;
            }

            head = (head).next;
            Console.WriteLine("The stack is modified");
            
        }
        public void peek()
        {
            if (!isEmpty())
            {
                Console.WriteLine("The stack is not modified");
                Console.WriteLine(head.data);
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return ;
            }
        }
        public bool isEmpty()
        {
            return head == null;
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
