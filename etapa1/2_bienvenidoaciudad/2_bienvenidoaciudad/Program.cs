using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_bienvenidoaciudad
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir por consola un nombre de persona y el nombre de una ciudad 
             * (no hace falta que sean reales o comprobarlos) y mostrar por pantalla, 
             * el siguiente mensaje «Hola » <nombre> » bienvenido a » <ciudad>*/
            Console.WriteLine("escriba un nombre");
            string nombre = (Console.ReadLine());
            Console.WriteLine("escriba una ciudad");
            string ciudad = (Console.ReadLine());

            Console.WriteLine("hola "+nombre+" bienvenido a "+ciudad);  


            Console.ReadKey();

        }
    }
}
