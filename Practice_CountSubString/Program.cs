using System;
using System.Text.RegularExpressions;

namespace Practice_CountSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            string str, sub;
            Console.WriteLine("Enter string");
            str = Console.ReadLine();

            Console.WriteLine("enter sub string");
            sub = Console.ReadLine();


            Console.WriteLine(sub);
            //if (str.Contains(sub))
            //{
            //    count = Regex.Matches(str, sub).Count;
            //    Console.WriteLine($"substring are {count} times in the string");
            //}
        }
    }
}
