using System;
using System.Linq;

namespace REC_72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку целых чисел разделяя из запятой");
            var ARR = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Array.Sort(ARR);
            Console.Write($"Отсортированная последовательность : ");
            foreach (int i in ARR)
                Console.Write($"{i} ");
            Console.ReadKey();
        }
    }
}
