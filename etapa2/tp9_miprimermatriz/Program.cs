using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp9_miprimermatriz
{
    class Program
    {
        static void Main(string[] args)
        {/*Crear una matriz de n×m con todos sus elementos inicializados
         a cero.  Imprimirla por pantalla
         n y m son datos que ingresa el usuario*/

            Console.WriteLine("ingrese el el valor de N y M");
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, M];
            for (int c = 0; c < M; c++)
            {

                for (int f = 0; f < N; f++)
                {
                    matriz[f, c] = 0;
                    Console.Write(matriz[f, c]+"\t");

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
