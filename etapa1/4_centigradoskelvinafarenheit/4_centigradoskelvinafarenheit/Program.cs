﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_centigradoskelvinafarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa una cantidad de grados pare convertirlos en Kelvin y Farenheit");
            int grados = int.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin:" + (grados + 273));
            Console.WriteLine("Farenheit:" + ((grados * 18) / 10) + 32);
            Console.ReadKey();
        }
    }
    }
}
