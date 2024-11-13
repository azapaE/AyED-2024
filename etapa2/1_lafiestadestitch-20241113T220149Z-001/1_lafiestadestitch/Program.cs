using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lafiestadestitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lilo está organizando una fiesta para los aliens invitados por Stitch y necesita gestionar
              la cantidad de comida necesaria. Para ello, ha creado un programa en C# que le ayudará a 
              calcular el promedio de comida que necesitará por invitado. El programa solicitará al 
              usuario que ingrese la cantidad de invitados y luego pedirá la cantidad de comida que cada 
              invitado consume, asegurándose de que los valores ingresados estén dentro del rango permitido
              (de 1 a 100). Una vez que se hayan ingresado todos los datos, el programa calculará el promedio
              de comida por invitado y lo mostrará en pantalla.

              El programa solicitará al usuario que ingrese la cantidad de invitados a la fiesta.Luego,
              para cada invitado, el programa solicitará que se ingrese la cantidad de comida que come 
              (un número entre 1 y 100), asegurándose de que el valor ingresado esté dentro del rango permitido.
              Si el valor ingresado no está dentro del rango, se mostrará un mensaje de error y se pedirá que se 
              ingrese nuevamente.Una vez que se hayan ingresado los datos de todos los invitados, el programa 
              calculará el promedio de comida por invitado.Finalmente, el programa mostrará en pantalla el promedio
              de comida por invitado.*/

            Console.WriteLine("escriba la cantidad de invitados para la fiesta de stitch");
            int inv = int.Parse(Console.ReadLine());
            int[] numinv = new int[inv];
            for(int cont = 0; cont <numinv.Count();cont++)
            {
                Console.WriteLine("escriba la cantidad de comida");
                int com = int.Parse(Console.ReadLine());

                if(com <= 100 && com >= 1)
                {
                    numinv[cont] = com;
                    Console.WriteLine(numinv[cont]);
                }
                else
                {
                    Console.WriteLine("error , la cantidad de comida debe ser entre 1 y 100");
                    cont--;
                }
                

            }
            int prom = 0;
            for (int cont = 0; cont < numinv.Count(); cont++)
            {

                prom += numinv[cont];
            }
            Console.WriteLine("el promedio es :" + (prom / inv));

                Console.ReadKey();
        }
    }
}
