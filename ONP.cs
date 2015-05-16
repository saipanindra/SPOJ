using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONP
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string expression = Console.ReadLine();
                foreach (char c in expression.ToCharArray())
                {
                    if (c >= 'a' && c <= 'z')
                        Console.Write(c);
                    else if (c == ')' && stack.Count > 0)
                    {
                        char p = stack.Pop();
                        Console.Write(p);
                    }
                    else if(c == '(') continue;
                    else
                        stack.Push(c);
                }
                Console.WriteLine();
                stack.Clear();
                t--;
            }
            Console.ReadLine();
        }
    }
}

                    
                    

