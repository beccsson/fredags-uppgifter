using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv dina ord här och avsluta genom att skriva avsluta");
            bool avsluta = false;
            string all_words = "";

            while (avsluta == false)
            {
                string new_word = Console.ReadLine();
                if (new_word == "avsluta")
                {
                    avsluta = true;

                }
                else
                {
                    all_words += new_word + " ";
                }
            }

            
        }
    }
}
