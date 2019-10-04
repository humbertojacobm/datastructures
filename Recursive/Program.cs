using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testing ...");
            Console.WriteLine("Factorial of :");            
            int number = Convert.ToInt32(Console.ReadLine());
            var factorial = Factorial(number);
            Console.WriteLine(string.Format("Is: {0}",factorial.ToString()));
            Console.ReadKey();

        }
        //4! = 1 x 2 x 3 x 4
        //4! => 0 , 1, 2, 3
        // 0 => 1x1 = 1
        // 1 => 1 x 2 =  2
        // 2 => 2 x 3 = 6

        //efficient is:
        //  x, 4 => 1 x 4 => 4
        //  x-1, 3   => 4 x 3 => 12
        // x-2, 2 => 12 x 2 => 24
        // x-3, 1 => 24 x 1 => 24

         //more eficient way:
         // 4! = 4 x (4-1) x (4-2) x (4-3) = 24
         //thread
        // number == 4 => return 4*Factorial(3)
                                      // return 3*Factorial(2)
                                                   //return 2*Factorial(1)
                                                                //1
                                                    //return 2*1
                                     // return 3*2*1
                         //return 4*3*2*1
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;

            return number * (Factorial(number - 1));

            //for (int i = number; i > 1; i--)
            //{
            //    initialValue *= i;
            //}

            //for (int i = 0; i < number; i++)
            //{
            //    initialValue *= (i + 1);
            //}

            //return initialValue;
        }
    }
}
