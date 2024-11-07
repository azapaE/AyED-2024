using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pregunte al usuario su edad
             *  y muestre por pantalla todos los años que ha cumplido (desde 1 hasta su edad).*/
            Console.WriteLine("¿cual es tu edad ?");
            int edad = int.Parse(Console.ReadLine());
            int e = edad;
            int contador = 0;

            while (contador < edad) {
                Console.WriteLine(e-edad + 1);
                e += 1;
                contador += 1;
               
                 }





                Console.ReadKey();
        }
    }
}
