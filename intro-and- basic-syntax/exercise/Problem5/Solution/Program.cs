using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string person = Console.ReadLine();
            int currh = int.Parse(Console.ReadLine());
            int maxh = int.Parse(Console.ReadLine());
            int curre = int.Parse(Console.ReadLine());
            int maxe = int.Parse(Console.ReadLine());
            //TODO
            Console.WriteLine("Name: " + person);
            Console.WriteLine("Health: " + "|" + new string('|', currh) + new string('.', maxh - currh) + "|");
            Console.WriteLine("Energy: " + "|" + new string('|', curre) + new string('.', maxe - curre) + "|");

        }
    }
}
