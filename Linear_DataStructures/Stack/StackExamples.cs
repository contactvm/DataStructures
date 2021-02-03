using System;
using System.Collections.Generic;
namespace Linear_DataStructures
{
   public class StackExamples
    {
        public static void Reverse(string input)
        {
            if (input == null)
                throw new InvalidOperationException("null string");
            Stack<char> stack = new Stack<char>();
            foreach (char a in input.ToCharArray())
            {
                stack.Push(a);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
        public static void CheckValidExpression(string expression)
        {
            Stack<char> ex = new Stack<char>();
            foreach (char a in expression.ToCharArray())
            {
                switch (a)
                {
                    case '(':
                    case '{':
                    case '[':
                    case '<':
                        ex.Push(a);
                        break;
                    case ')':
                    case '}':
                    case ']':
                    case '>':
                        {
                            if (ex.Count != 0)
                            {
                                if (ex.Peek() == '(' && a == ')')
                                {
                                    ex.Pop();
                                }
                                else if (ex.Peek() == '{' && a == '}')
                                {
                                    ex.Pop();
                                }
                                else if (ex.Peek() == '[' && a == ']')
                                {
                                    ex.Pop();
                                }
                                else if (ex.Peek() == '<' && a == '>')
                                {
                                    ex.Pop();
                                }
                                else
                                {
                                    //  return;
                                }
                            }
                            break;
                        }
                }
            }
            if (ex.Count != 0)
            {
                Console.WriteLine("Invalid expression");
            }
            else
            {
                Console.WriteLine("valid expression");
            }
        }
        public static void DriverCode()
        {
            try
            {
                Reverse("abcd");//valid case
                Reverse("");//empty string
                            //  Reverse(null);

                CheckValidExpression("([{a}+b])");
                CheckValidExpression("}{");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
