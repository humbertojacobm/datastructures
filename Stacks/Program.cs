using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Stacks1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("1st element");
            myStack.Push("2st element");
            myStack.Push("3st element");
            myStack.Push("4st element");
            myStack.Push("5st element");
            myStack.Push("6st element");

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            if(myStack.Contains("1st element"))
            {
                Console.WriteLine("element was found ... !!!");
            }
            else
            {
                Console.WriteLine("element NOT was found ... !!!");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("total number is {0}", myStack.Count);
            Console.WriteLine();

            Console.WriteLine("Element top is {0}", myStack.Peek());

            Console.WriteLine("Element top is {0}", myStack.Peek());

            Console.WriteLine();
            Console.WriteLine("total number is {0}", myStack.Count);
            Console.WriteLine();

            myStack.Clear();
            Console.WriteLine("total number is {0}", myStack.Count);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
