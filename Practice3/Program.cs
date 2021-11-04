using System;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //get 2 arrays and compare which one has higher sum?
            int[] array1 = new int[3];
            int[] array2 = new int[3];
            int array1Sum = 0;
            int array2Sum = 0;

            Console.WriteLine("Enter three numbers for 1st array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
                array1Sum += array1[i];
            }

            Console.WriteLine("Enter three numbers for 2st array: ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
                array2Sum += array2[i];
            }

            if (array1Sum > array2Sum)
            {
                Console.WriteLine($"Array 1 is bigger with sum of {array1Sum}");
            }
            else
            {
                Console.WriteLine($"Array 2 is bigger with sum of {array2Sum}");
            }
            Console.ReadLine();

        }
    }
}
