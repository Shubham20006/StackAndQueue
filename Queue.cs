using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue_UsingLinkedList
{
    public class Queue
    {
        public Node head, tail;
        public Queue()
        {
            this.head = this.tail = null;
        }
        public void enqueue(int data)
        {
           Node temp = new Node(data);
            if (this.tail == null)
            {
                this.head = this.tail = temp;
                return;
            }

            this.tail.next = temp;
            this.tail = temp;

        }
        public void dequeue()
        { 
            if (this.head == null)
                return;          
            this.head = this.head.next;           
        }
        public bool isEmpty()
        {
            return head == null;
        }
    
        public void display()
        {
            // check for stack underflow
            if (head == null)
            {
                Console.Write("Empty");
                return;
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {

                    // print node data
                    Console.Write(temp.data);

                    // assign temp link to temp
                    temp = temp.next;
                    if (temp != null)
                        Console.Write("->");
                }
            }


        }
    }        
}
