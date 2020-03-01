using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 2 от Word 13

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int index = 0; index < numbers.Count; index++)
            {
                Console.WriteLine("list[{0}] = {1}", index, numbers[index]);
            }

            Console.ReadLine();
        }
    }
}
