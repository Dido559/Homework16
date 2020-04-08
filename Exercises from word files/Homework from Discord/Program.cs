using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistancionnoDomashno2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                string comm = input[0].ToLower();
                switch (comm)
                {
                    case "a":
                        {
                            phonebook.Add(input[1], input[2]);
                            break;

                        }
                    case "s":
                        {
                           if (phonebook.ContainsKey(input[1]))
                           {
                                Console.WriteLine($"Name: {input[1]} | Number: {phonebook[input[1]]}");
                           }
                            else
                            {
                                Console.WriteLine($"The contact you wanted to view doesn't exist!");
                            }
                            break;
                        }
                    case "end":
                        {
                            return;
                        }
                }
                




            }
        }
    }
}
