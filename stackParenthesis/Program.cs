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

       

        static void Main(string[] args)
        {

            // {([])} => balanced
            //{ , ( , [ , ] , ), }

            // { , ( , [
            // ] , ), }

            // { , ( , [
            // } , ), ]

            // queue { , ( , [
            // Stack  } , ), ]


            // {([])}
            // })][({

            // a{b(c[d]f)g}
            // {([])}


            var expresion1 = "{{([])}}";

            Console.WriteLine(expresion1);

            bool isBalance = true;

            char[] arrExpression = expresion1.ToCharArray();

            LinkedList<string> justParenthesisFamily = new LinkedList<string>();
            Stack mirrorParenthesisList = new Stack();

            foreach (var item in arrExpression)
            {

                if(item == char.Parse("{") || item == char.Parse("}") || item == char.Parse("(") || item == char.Parse(")") || item == char.Parse("[") || item == char.Parse("]"))
                {
                    justParenthesisFamily.AddLast(item.ToString());
                    mirrorParenthesisList.Push(item.ToString());
                }
            }
            
            foreach (var item in justParenthesisFamily.Take(justParenthesisFamily.Count/2))
            {
                var top = mirrorParenthesisList.Pop();
                
                switch (item)
                {
                    case "{":
                        isBalance= CheckingPair(top.ToString(), "}");    
                        break;
                    case "}":
                        isBalance = CheckingPair(top.ToString(), "{");
                        break;
                    case "(":
                        isBalance = CheckingPair(top.ToString(), ")");
                        break;
                    case ")":
                        isBalance = CheckingPair(top.ToString(), "(");
                        break;
                    case "[":
                        isBalance = CheckingPair(top.ToString(), "]");
                        break;
                    case "]":
                        isBalance = CheckingPair(top.ToString(), "[");
                        break;
                    default:
                        break;
                }

                if (!isBalance)
                {
                    break;
                }
            }

            Console.WriteLine("Is balance {0}", isBalance.ToString());

            //Console.WriteLine();
            //foreach (var item in justParenthesisFamily)
            //{

            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (var item in mirrorParenthesisList)
            //{                
            //    Console.WriteLine(item);
            //}

            //Stack s1 = new Stack();

            //foreach (var item in arrExpression)
            //{
            //    s1.Push(item);
            //    //{a(b[c]d)e}
            //    //}e)d]c[b(a{
            //}

            ////o :  {
            ////s1:  }
            //var isBalanced = true;
            //foreach (var item in arrExpression)
            //{
            //    var value = s1.Pop();

            //    if(value == "}" || value == ")" || value == "]")
            //    {
            //        if ((value == "}" && value == item) || (value == ")" && value == item) || (value == "]" && value == item))
            //        {
            //            continue;
            //        }
            //        isBalanced = false;
            //        break;
            //    }                
            //}

            Console.ReadKey();




        }

        private static bool CheckingPair(string top, string pair)
        {
            if (top != pair)
            {                
                return false;
            }
            return true;
        }
    }
}
