﻿using System;

namespace Beverage
{
class Beverage
{
    static void Main()
    {
        //TODO
        string name = Console.ReadLine();
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        double energy = a * (b * 0.01);
        double sugar = a * (c * 0.01);

        Console.WriteLine(a + "ml" + " " + name + ":");
        Console.WriteLine(energy + "kcal, " + sugar + "g sugars");
    }
}
}
