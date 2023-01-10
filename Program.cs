using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue_UsingLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack obj = new Stack();

            // insert Stack value
            obj.push(70);
            obj.push(30);
            obj.push(56);

            // print Stack elements
            Console.WriteLine("------After push------");
            obj.Display();
            Console.WriteLine("\n--------------------------------------------");

        }
    }
}
