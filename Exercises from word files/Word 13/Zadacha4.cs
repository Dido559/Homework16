using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 4 от Word 13

            var imena = Console.ReadLine().Split(',').ToList();
            foreach (var name in imena)
            {
                Console.WriteLine(String.Join(" ", name.Split(' ').Reverse()));
            }

            Console.ReadLine();
        }
    }
}
