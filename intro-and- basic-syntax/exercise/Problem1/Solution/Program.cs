﻿//CONFIRMED from <i_villani>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            List<string> gogo = new List<string>();
            for (int i = 1; i <= 4; i++)
            {
                int s = int.Parse(Console.ReadLine());
                gogo.Add(s.ToString());
            }
            for (int i = 0; i < 4; i++)
            {

                Console.Write(new string('0', 4 - gogo[i].Length) + gogo[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
