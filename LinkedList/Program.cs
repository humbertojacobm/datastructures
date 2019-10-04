using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> my_list = new LinkedList<string>();

            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");

            Console.WriteLine("Best students: ");
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            if (my_list.Contains("Shilpa"))
            {
                Console.WriteLine("Element Found .... !!!");
            }
            else
            {
                Console.WriteLine("Element Not found ...!!");
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Best students of XYZ" +
                         " university in 2000:");

            my_list.Remove(my_list.First);

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            // After using Remove(T) method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2001:");

            my_list.Remove("Rohit");

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }


            Console.WriteLine();

            // After using RemoveFirst() method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2002:");

            my_list.RemoveFirst();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            // After using RemoveLast() method 
            Console.WriteLine("Best students of XYZ" +
                             " university in 2003:");

            my_list.RemoveLast();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            // After using Clear() method 
            my_list.Clear();
            Console.WriteLine("Number of students: {0}",
                                         my_list.Count);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
