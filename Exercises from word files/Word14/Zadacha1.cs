using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> spisak = new List<int>();

            for (int i = 0; i < n; i++)
            {
                spisak.Add(int.Parse(Console.ReadLine()));
            }

            for (int index = 0; index < spisak.Count; index++)
            {
                Console.WriteLine("list[{0}] = {1}", index, spisak[index]);
            }

            Console.ReadLine();
        }
    }
}
