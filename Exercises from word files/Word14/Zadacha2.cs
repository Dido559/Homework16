﻿using System;
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
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write($" {numbers[i]} ");
                } 

            }

            Console.ReadLine();
        }
    }
}
