using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();

            Console.WriteLine("enter sub string");
            char sub = Convert.ToChar(Console.ReadLine());

            if (str.Contains(sub))
            {
             count=
                str.Count(s => s == sub);
           Console.WriteLine(count); 
            }
         
            
        }
    }
}
