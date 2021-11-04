using System;

namespace Practice4_StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 3 string array values, compare the length of each.
            string[] str = new string[3];
            int[] strLength = new int[3];
            

            Console.WriteLine("Enter three strings and I will compare the length");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("\nEnter: ");
                str[i] = Console.ReadLine();
                strLength[i] = str[i].Length;
                
            }


            if (strLength[0]>strLength[1] && strLength[0]>strLength[2])
            {
                Console.WriteLine($"\nstring { str[0]} has longest word. " );
            }
            else if (strLength[1] > strLength[2] && strLength[1] > strLength[0])
            {
                Console.WriteLine($"\nstring { str[1]} has longest word. ");
            }
            else
            {
                Console.WriteLine($"\nstring { str[2]} has longest word. ");
            }



            Console.ReadLine();

        }
    }
}
