using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackParenthesis
{
    public sealed class ParenthesisLogic
    {
        public ParenthesisLogic()
        {

        }

        private static readonly object _padlock = new object();

        private static ParenthesisLogic _instance = null;

        public static ParenthesisLogic Instance
        {
            get
            {
                lock(_padlock)
                {
                    if(_instance == null)
                    {
                        _instance = new ParenthesisLogic();
                    }
                    return _instance;
                }
            }
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
}
