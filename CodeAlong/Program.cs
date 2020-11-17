using System;
using System.Linq;

namespace CodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1

            //Ett sätt
            int[] arrayOfNumbers = new int[5] { 13, 22, 3, 93, 1 };

            Console.WriteLine("Check if you picked a lucky number");
            int mynr = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (mynr == arrayOfNumbers[i])
                {
                    Console.WriteLine("Winner winner potato dinner");
                }
            }

            //Ett annat sätt
            Console.WriteLine(arrayOfNumbers.Contains(1));



            //övning 2
            //Ett sätt
            int[] firstOne = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] secondOne = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //Console.WriteLine(string.Join(',', firstOne));
            //Console.WriteLine(string.Join(',', secondOne));

            //Ett annat sätt
            Console.WriteLine(string.Join(',', firstOne));
            Console.WriteLine(string.Join(',', firstOne.Reverse()));

            


        }
    }
}
