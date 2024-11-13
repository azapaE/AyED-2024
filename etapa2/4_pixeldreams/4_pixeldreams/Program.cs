using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_pixeldreams
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En la empresa de videojuegos "Pixel Dreams", se está organizando un torneo en línea de
             su juego más popular, "Galaxy Quest". Para determinar los ganadores, necesitan un programa 
             que ordene los puntajes de los jugadores de mayor a menor.
             El programa solicitará al usuario que ingrese la cantidad de participantes en el torneo.
             Luego, pedirá al usuario que ingrese los puntajes de cada participante, uno por uno.
             Una vez ingresados todos los puntajes, el programa los ordenará de mayor a menor.Finalmente,
             mostrará la lista de puntajes ordenados, indicando el primer lugar (mayor puntaje) y
             el último lugar (menor puntaje).*/

            Console.WriteLine("ingrse la cantidad de participantes del torneo");

            int cantparticipantes = int.Parse(Console.ReadLine());
            int[] participantes = new int[cantparticipantes];
            for(int i =0;i< participantes.Count();i++)
            {
                Console.WriteLine("ingrese el puntaje de cada participante n°" +(i+1));
                int puntaje = int.Parse(Console.ReadLine());
                participantes[i] += puntaje;

            }
            int puntajeM = 0;
            for(int i = 0; i<participantes.Count();i++)
            {
                if (participantes[i]> puntajeM)
                {
                    puntajeM = participantes[i];
                }
                else
                {


                }
                Console.WriteLine(participantes[i]);



            }








                Console.ReadKey();
        }
    }
}
