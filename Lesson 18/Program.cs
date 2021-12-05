using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18
{
    //1.    Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
    //Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.
    //Указание: задача решается однократным проходом по символам заданной строки слева направо;
    //для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая,
    //каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается);
    //в конце прохода стек должен быть пуст.
    class Program
    {
        static void Main(string[] args)
        {

            string bracets = "[{({})[]]";
            
            char[] arrayBrackets = new char[bracets.Length];
            arrayBrackets = bracets.ToCharArray();
            Stack<char> stackBreackets=new Stack<char>();
            int count = 0;
            for (int i = 0; i < arrayBrackets.Length; i++)
            {
                char bracet = arrayBrackets[i];
                try
                {
                    switch (bracet)
                    {
                        case '(':
                            stackBreackets.Push(')');
                            break;
                        case '[':
                            stackBreackets.Push(']');
                            break;
                        case '{':
                            stackBreackets.Push('}');
                            break;
                        case ')':
                            if (stackBreackets.Peek() == ')')
                            {
                                stackBreackets.Pop();
                                count++;
                            }
                            else
                            {
                                count = 0;
                            }
                            break;
                        case ']':
                            if (stackBreackets.Peek() == ']' && stackBreackets.Peek() != ' ')
                            {
                                stackBreackets.Pop();
                                count++;
                            }
                            else
                            {
                                count = 0;
                            }
                            break;
                        case '}':
                            if (stackBreackets.Peek() == '}')
                            {
                                stackBreackets.Pop();
                                count++;
                            }
                            else
                            {
                                count = 0;
                            }
                            break;

                    }
                }


                catch (Exception)
                {
                    //Console.WriteLine("Не корректно расставлены скобки.");
                    count = 0;
                }

            }
            if (count!=arrayBrackets.Length/2)
            {
                Console.WriteLine("Не корректно расставлены скобки.");
            }
            else
            {
                Console.WriteLine("Корректно расставлены скобки.");
            }
            Console.ReadKey();
        }
    }
}
