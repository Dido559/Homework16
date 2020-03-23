using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashna_rabota
{
    class Program
    {
        static void Main(string[] args)
        {
            string didi = Console.ReadLine();
            if(didi.Length < 7)
            {
                Console.WriteLine("The string is too small! ;(");

            }
            else
            {
                int length = didi.Length;
              
                Console.WriteLine($"Without first 3 letters: {didi.Substring(3)}");
                Console.WriteLine($"Without last 3 letters: {didi.Substring(0, length - 3)}");
                Console.WriteLine($"Without first and last 3 letters {didi.Substring(3, length - 6)}");


            }
            Console.ReadLine();
        }
    }
}
