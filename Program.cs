using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue_UsingLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue obj = new Queue();
            Console.WriteLine("After Enqueue");
            // insert Stack value
            obj.enqueue(56);
            obj.enqueue(30);
            obj.enqueue(70);
            obj.display();
            
            Console.WriteLine("\n-----------------");
            Console.WriteLine("Queue Empty : "+obj.isEmpty());
            Console.WriteLine("\n-----------------");
            Console.WriteLine("After Dequeue");
                obj.dequeue();
            obj.display();
            Console.WriteLine("\n-----------------");
            Console.WriteLine("After Dequeue");
            obj.dequeue();
            obj.display();
            Console.WriteLine("\n-----------------");
            Console.WriteLine("After Dequeue");
            obj.dequeue();
            obj.display();
            Console.WriteLine("\n-----------------");
            Console.WriteLine("Queue Empty : "+obj.isEmpty());
            Console.ReadLine();

        }
    }
}
