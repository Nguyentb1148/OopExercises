using System;

namespace OOPCSharpExercises._03.WorkingWithAbstraction_Lab._01.RhombusOfStars
{
    public class Startup
    {
        public static void RhombusOfStarts()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                PrintRow(number, i);
            }

            for (int i = number - 1; i >= 1; i--)
            {
                PrintRow(number, i);
            }
        }

        private static void PrintRow(int number, int i)
        {
            Console.Write(new string(' ', number - i));
            Console.Write("*");
            for (int j = 1; j < i; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}