using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue myQueue = new Queue();
            myQueue.Enqueue("GFG"); ;
            myQueue.Enqueue(1);
            myQueue.Enqueue(100);
            myQueue.Enqueue("GeeksforGeeks");
            myQueue.Enqueue(null);
            myQueue.Enqueue(2.4);
            myQueue.Enqueue("Geeks123");

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            if (myQueue.Contains("GeeksforGeeks"))
            {
                Console.WriteLine("Element available ... !!");
            }
            else
            {
                Console.WriteLine("Element not available ... !!");
            }

            Console.WriteLine();

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                    myQueue.Count);

            // Obtain the topmost element of my_queue 
            // Using Dequeue method 
            Console.WriteLine("Topmost element of my_queue"
                         + " is: {0}",myQueue.Dequeue());

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                                myQueue.Count);


            Console.WriteLine();
            Console.WriteLine("Topmost element of my_queue"
                         + " is: {0}", myQueue.Peek());

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                                myQueue.Count);
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
