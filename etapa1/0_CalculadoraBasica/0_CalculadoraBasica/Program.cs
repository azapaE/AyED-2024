﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine(numero + " + " + numero2 + " = " + (numero + numero2));
            Console.WriteLine(numero + " - " + numero2 + " = " + (numero - numero2));
            Console.WriteLine(numero + " * " + numero2 + " = " + (numero * numero2));
            Console.WriteLine(numero + " / " + numero2 + " = " + (numero / numero2));
            Console.WriteLine("el resto de " + numero + "  y  " + numero2 + " es " + (numero % numero2));
            Console.ReadKey();
        }
    }
}
