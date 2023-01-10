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
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("------After pop------");
                obj.pop();
                obj.Display();
                Console.WriteLine("\n--------------------------------------------");
                Console.WriteLine("------After peek------");
                obj.peek();
                Console.WriteLine("\n--------------------------------------------");
                Console.WriteLine("------Stack Empty : True/False------");
                Console.WriteLine(obj.isEmpty());
                Console.WriteLine("\n--------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
