﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to any hexadecimal number to its decimal equivalent:
            string Input;
            Console.WriteLine("Enter a Hexadecimal Number :");
            Input = Console.ReadLine();
            int Output = int.Parse(Input, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("The Decimal value is " + Output);
            Console.ReadLine();
        }
    }
}
