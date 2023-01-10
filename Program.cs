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

            // insert Queue value
            obj.enqueue(56);
            obj.enqueue(30);
            obj.enqueue(70);
            obj.display();
           
            
            Console.ReadLine();

        }
    }
}
