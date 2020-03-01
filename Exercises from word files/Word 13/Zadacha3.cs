using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 3 от Word 13

            var names = Console.ReadLine().Split(' ');

            Console.WriteLine(String.Join("; ", names));

            Console.ReadLine();
        }
    }
}
