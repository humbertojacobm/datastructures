using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackParenthesisStrategy
{
    public abstract class LogicStrategy
    {
        public abstract bool isBalancedExpressionInterface(string expression);
    }

    public class HmoriLogicStrategy: LogicStrategy
    {
        public override bool isBalancedExpressionInterface(string expression)
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

        private bool isCoupleComparisson(string girlfriend, string boyfriend)
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

        private bool isOpenKey(string key)
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
        private bool isCloseKey(string key)
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

    public class LogicContext
    {
        private LogicStrategy _strategy;

        public LogicContext(LogicStrategy strategy)
        {
            this._strategy = strategy;
        }
        public bool isBalanced(string expression)
        {
            return _strategy.isBalancedExpressionInterface(expression);
        }
    }

}
