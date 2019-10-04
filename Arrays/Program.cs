using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numberArray;

            numberArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numberArray[i] = i + 100;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numberArray[i].ToString());
            }

            Console.ReadKey();
             
        }


    }
}
