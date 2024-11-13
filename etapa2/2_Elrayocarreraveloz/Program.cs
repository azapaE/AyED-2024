using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Elrayocarreraveloz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*El Rayo McQueen está compitiendo en una carrera de alta velocidad. Necesita un programa
              en C# que le ayude a registrar los tiempos de cada vuelta y calcular algunas estadísticas importantes. 

             El programa debe:
             Permitir a Rayo McQueen ingresar los tiempos de cada vuelta de la carrera en segundos.
             Utiliza un array para almacenar estos tiempos.
             Calcular y mostrar en pantalla el tiempo total de la carrera.
             Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
             Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, 
             la vuelta con el menor tiempo registrado.
             El programa debe permitir al usuario ingresar la cantidad de vueltas que completó Rayo McQueen y 
             luego ingresar los tiempos de cada vuelta. Al finalizar, mostrará las estadísticas calculadas.*/
            Console.WriteLine("ingrese cuantas vueltas dio McQueen ");
            int vuel = int.Parse(Console.ReadLine());
            int[] tam = new int[vuel];
            for (int cont = 0; cont < tam.Count(); cont++)
            {
                Console.WriteLine("ingrese el tiempo que dio en la vuelta " + (cont + 1));
                int tiempo = int.Parse(Console.ReadLine());
                tam[cont] = tiempo;
            }
            int timeTotal = 0;
            int mejortiem = 100;
            for (int cont = 0; cont < tam.Count(); cont++)
            {
                timeTotal += tam[cont];
            }
            for(int i = 0;i < tam.Count();i++)
            {
                if (tam[i] < mejortiem)
                {
                    mejortiem = tam[i];
                }

            }


            Console.WriteLine("tardo en completar la carrera en: " + timeTotal + " segundos");
            Console.WriteLine("el tiempo promedio por cada vuelta es: " + (timeTotal / vuel) + " segundos");
            Console.WriteLine("el mejor tiempo es: " + mejortiem + " segundos");
            Console.ReadKey();







        }
    }
}
