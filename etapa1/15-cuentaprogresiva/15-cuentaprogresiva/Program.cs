using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_cuentaprogresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pida al usuario un número entero positivo
              y muestre por pantalla la cuenta atrás desde ese número hasta cero.*/
            Console.WriteLine("escribe un numero entero positivo");
            int numero = int.Parse(Console.ReadLine());
            int contador = -1;
            int cuentareg = numero;
            while (contador < numero) {
                Console.WriteLine(cuentareg-1+1);
                cuentareg -= 1;
                contador += 1;
                 }
            Console.ReadKey();


        }
    }
}
