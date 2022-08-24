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
            Regex reg = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b");
            string text = Console.ReadLine();
            MatchCollection mach = reg.Matches(text);

            foreach (Match m in mach)
            {
                Console.Write(m.Value + " ");
            }

            Regex reg2 = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b");
            string text2 = Console.ReadLine();
            MatchCollection mach2 = reg2.Matches(text);

            foreach (Match m in mach2)
            {
                Console.Write(m.Value + " ");
            }



        }

    }
}
