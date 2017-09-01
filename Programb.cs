using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in en mening");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            foreach (string word in words)

            {
                Console.WriteLine(word);
            }
            Array.Reverse(words);
            foreach (string word in words)

            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
