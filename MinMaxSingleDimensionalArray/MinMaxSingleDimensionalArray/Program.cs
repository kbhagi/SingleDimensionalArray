﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinMaxSingleDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, -10, -20, 0, 15, 20, 30 };
            Console.WriteLine("Maximum Element: " + array1.Max());
            Console.WriteLine("Minimum Element: " + array1.Min());
            Console.Read();
        }

    }
}
