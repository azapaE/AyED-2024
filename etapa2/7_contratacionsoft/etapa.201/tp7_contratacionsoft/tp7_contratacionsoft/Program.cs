using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7_contratacionsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una empresa de desarrollo de software está en proceso de contratar un nuevo equipo para
              un proyecto importante. Durante el proceso de selección, necesitan un programa que ordene
              los puntajes obtenidos en un examen de menor a mayor, y luego filtre aquellos puntajes que
              sean múltiplos de un número dado.

              El programa solicitará al usuario que ingrese la cantidad de candidatos que realizaron el
              examen.Luego, pedirá al usuario que ingrese los puntajes de cada candidato, uno por uno.Una
              vez ingresados todos los puntajes, el programa los ordenará de menor a mayor.Posteriormente,
              el programa solicitará al usuario que ingrese un número entero para filtrar los puntajes
              múltiplos de ese número.Finalmente, mostrará al usuario la lista de puntajes ordenados y
              los puntajes que son múltiplos del número especificado.*/


            Console.WriteLine("escriba la cantidad de candidatos que realizaron el examen");
            int exam = int.Parse(Console.ReadLine());
            int[] cant = new int[exam];
            int filtro = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba un numero entero para filtrar lus multiplos q pusiste ");
            for (int i = 0; i < cant.Count(); i++)
            {
                Console.WriteLine("escriba el puntaje en cada candidato n° " + (i+1));
                int punt = int.Parse(Console.ReadLine());
                cant[i] = punt;
                if (punt % filtro ==1)
                {
                    cant[i] = punt;
                }
                else if (punt % filtro == 0)
                {
                    cant[i] = punt;
                }
            }
            for(int i =0; i<cant.Count() -1;i++)
            {
                for(int j = 0; j < cant.Count() -1-i;i++)
                {
                    if(cant[j]< cant[j+1])
                    {
                        int temp = cant[j];
                        cant[j] = cant[j + 1];
                        cant[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < cant.Count();i++)
            {
                Console.WriteLine("        " + cant[i]);
            }

            Console.ReadKey();

        }
    }
}
