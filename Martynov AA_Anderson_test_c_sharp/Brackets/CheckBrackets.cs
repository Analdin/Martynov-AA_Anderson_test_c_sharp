using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martynov_AA_Anderson_test_c_sharp.Brackets
{
    public class CheckBrackets
    {
        public void JobWithBrackets()
        {
            Stack<char> stack = new Stack<char>();

            Console.WriteLine("Введите последовательность из скобок:");

            string txt = Convert.ToString(Console.ReadLine());

            for(int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '(')
                    stack.Push('(');
                else if (txt[i] == ')' & stack.Count > 0)
                    stack.Pop();
            }

            Console.WriteLine(stack.Count == 0 ? "Выражение верное." : "Выражение не верное!");
            Console.ReadKey();
        }
    }
}
