// CONFIRMED from <BorislavJS>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            double input = double.Parse(Console.ReadLine());
            double result = input * 1.60934;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
