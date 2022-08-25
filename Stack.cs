using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
namespace SoftUniExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

  
            string[] splited = Console.ReadLine().Split(" ");

            for (int i = splited.Length-1; i >= 0; i--)
            {

                stack.Push(splited[i]);
            }

            while (stack.Count>2)
            {
                int firstNum = int.Parse(stack.Peek());
                stack.Pop();
                char symbol = char.Parse(stack.Peek());
                stack.Pop();
                int secNum = int.Parse(stack.Peek());
                stack.Pop();
                int result = 0;
                if (symbol=='+')
                {
                    result = firstNum + secNum;
                }
                else if (symbol=='-')
                {
                    result = firstNum - secNum;

                }
                stack.Push(result.ToString());

            }
            Console.WriteLine(stack.Peek());
            ////////////////////////////////////////////

            string input = Console.ReadLine();
            Stack<string> stack2 = new Stack<string>();


            for (int i = 0; i < input.Length; i++)
            {
                string s = input[i].ToString();
                stack.Push(s);
            }
            foreach (var st in stack)
            {
                Console.Write(st);
            }
            ////////////////////////////////////////////////
            string[] numbers = Console.ReadLine().Split(" ");
            int sum = 0;
            Stack<int> stack3 = new Stack<int>();

            foreach (var numb in numbers)
            {
                stack3.Push(int.Parse(numb));
            }
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] splited2 = command.Split(" ");
                if (splited[0] == "add")
                {
                    stack3.Push(int.Parse(splited[1]));
                    stack3.Push(int.Parse(splited[2]));

                }
                if (splited[0] == "remove")
                {
                    int removenumbers = int.Parse(splited[1]);
                    if (stack.Count > removenumbers)
                    {
                        for (int i = 0; i < removenumbers; i++)
                        {
                            stack.Pop();

                        }




                    }

                }
                command = Console.ReadLine();
            }
            int counts = stack.Count;
            for (int i = 0; i < counts; i++)
            {
                sum += stack3.Pop();
            }
            Console.WriteLine("Sum: " + sum);



























        }
    }
}