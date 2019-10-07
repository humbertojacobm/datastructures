using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackParenthesisStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var expresion1 = "[()]{}{[()()]()}";
            //var expresion1 = "[(])";

            Console.WriteLine(expresion1);

            Console.WriteLine("Es balanceada ?: " + new LogicContext(new HmoriLogicStrategy()).isBalanced(expresion1));

            Console.ReadKey();
        }
    }
}
