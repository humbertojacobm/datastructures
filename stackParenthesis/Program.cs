using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

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

            isBalance = isBalancedExpression(expresion1);

            Console.WriteLine("Es balanceada ?: "+ isBalance.ToString());
            //foreach (var item in justParenthesisFamily)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }

        private static bool isBalancedExpression(string expression)
        {
                  
            List<char> parenthList = (expression.ToList()).Where(x => isOpenKey(x.ToString()) || isCloseKey(x.ToString())).ToList();
            if (parenthList.Count%2!=0)
            {
                return false;
            }
            Queue<char> justParenthesisFamily = new Queue<char>(parenthList);
            Stack<char> openParenth = new Stack<char>();
            char first = justParenthesisFamily.Dequeue();
            char last = justParenthesisFamily.Last();
            if (!(isOpenKey(first.ToString()) && isCloseKey(last.ToString())))
            {
                return false;
            }

            openParenth.Push(first);

            while(justParenthesisFamily.Count>0 || openParenth.Count>0)
            {
                var familyTop = justParenthesisFamily.Peek();
                if (isCloseKey(familyTop.ToString()))
                {                    
                    if(isCoupleComparisson(openParenth.Peek().ToString(), familyTop.ToString()))
                    {
                        justParenthesisFamily.Dequeue();
                        openParenth.Pop();                        
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    openParenth.Push(justParenthesisFamily.Dequeue());
                }
            }

            if (justParenthesisFamily.Count > 0 || openParenth.Count > 0)
            {
                return false;
            }
            else

            return true;
        }

        private static bool isCoupleComparisson(string girlfriend, string boyfriend)
        {
            var isCouple = false;
            switch (girlfriend)
            {
                case "{":
                    if(boyfriend=="}")
                    {
                        isCouple = true;
                    }
                    break;
                case "[":
                    if (boyfriend == "]")
                    {
                        isCouple = true;
                    }
                    break;
                case "(":
                    if (boyfriend == ")")
                    {
                        isCouple = true;
                    }
                    break;
                default:
                    break;
            }
            return isCouple;
        }

        private static bool isOpenKey(string key)
        {
            var isOpen = false;
            switch (key)
            {
                case "{":
                    isOpen = true;
                    break;
                case "[":
                    isOpen = true;
                    break;
                case "(":
                    isOpen = true;
                    break;
                default:
                    break;
            }
            return isOpen;
        }
        private static bool isCloseKey(string key)
        {
            var isOpen = false;
            switch (key)
            {
                case "}":
                    isOpen = true;
                    break;
                case "]":
                    isOpen = true;
                    break;
                case ")":
                    isOpen = true;
                    break;
                default:
                    break;
            }
            return isOpen;
        }
    }
}
