using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackParenthesisFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var expresion1 = "[()]{}{[()()]()}";            
            //var expresion1 = "[(])";
            
            Console.WriteLine(expresion1);                

            Checker checker = new HmoriCheckerFactory(expresion1).GetChecker();            

            Console.WriteLine("Es balanceada ?: " + checker.isBalanced.ToString());            

            Console.ReadKey();
        }
    }
}
