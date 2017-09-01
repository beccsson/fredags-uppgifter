using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u01091701
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening.");
            String s = Console.ReadLine();


            String[] antal = s.Split(' ');
            Console.WriteLine(antal.Length);


            foreach (String word in antal)
            {
                int numberOfLetters = word.Length;
                Console.WriteLine(word + " (" + numberOfLetters + ")");
            }

            Console.ReadKey();









        }
    }
}
