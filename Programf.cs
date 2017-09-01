using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppfift_f
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int the_numb = r.Next(21);

            Console.Write(the_numb);
            Console.WriteLine("Gissa numret, mellan 1-21");

            while (Convert.ToInt32(Console.ReadLine()) != the_numb)
            {
                Console.WriteLine("Gissa igen ");
            }
            Console.WriteLine("Du gisade rätt!");
            
        }
    }
}
