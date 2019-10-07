using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stackParenthesis
{
    class Program
    {

        //   [,o
        //   ],c
        //   (,o
        //   ), c
        //   {, o
        //   }, c

        //[()]{}{[()()]()}
        //clean de other letters.
        //o,o,c,c,o,c,o,o,o,c,o,c,c,o,c,c
        //just possible to begin with "o" {([
        //just possible to finish with "c" })]
        //always is pair
        // ,,,,,,,,,,,,,,,
        // ,,,,


        static void Main(string[] args)
        {
            //var expresion1 = "[()]{}{[()()]()}";            
            var expresion1 = "[(])";
            bool isBalance = true;

            Console.WriteLine(expresion1);

            isBalance = ParenthesisLogic.Instance.isBalancedExpression(expresion1);

            Console.WriteLine("Es balanceada ?: "+ isBalance.ToString());
            //foreach (var item in justParenthesisFamily)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }

    }
}
