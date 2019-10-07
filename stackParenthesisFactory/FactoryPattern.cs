using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackParenthesisFactory
{
    public abstract class Checker
    {        
        public abstract string expression { get; set; }
        public abstract bool isBalanced { get; }
    }

    public abstract class FirstChecker : Checker
    {
        public bool isCoupleComparisson(string girlfriend, string boyfriend)
        {
            var isCouple = false;
            switch (girlfriend)
            {
                case "{":
                    if (boyfriend == "}")
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

        public bool isOpenKey(string key)
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
        public bool isCloseKey(string key)
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

    public class HmoriChecker : FirstChecker
    {

        private string _expression;

        public HmoriChecker(string expression)
        {
            this._expression = expression;
        }

        public override string expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        public override bool isBalanced
        {
            get { return isBalancedExpression(_expression); }
        }

        public bool isBalancedExpression(string expression)
        {

            List<char> parenthList = (expression.ToList()).Where(x => isOpenKey(x.ToString()) || isCloseKey(x.ToString())).ToList();
            if (parenthList.Count % 2 != 0)
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

            while (justParenthesisFamily.Count > 0 || openParenth.Count > 0)
            {
                var familyTop = justParenthesisFamily.Peek();
                if (isCloseKey(familyTop.ToString()))
                {
                    if (isCoupleComparisson(openParenth.Peek().ToString(), familyTop.ToString()))
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

    }

    public abstract class CheckerFactory
    {
        public abstract Checker GetChecker();
    }

    public class HmoriCheckerFactory : CheckerFactory
    {
        private string _expression;       
        public HmoriCheckerFactory(string expression)
        {            
            this._expression = expression;            
        }

        public override Checker GetChecker()
        {
            return new HmoriChecker(_expression);
        }
    }

}
