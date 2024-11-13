using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_lacarreradehomero
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homero Simpson está participando en una carrera de obstáculos.
            Cada obstáculo tiene una dificultad diferente (representada por un número entero).
            Ayuda a Homero a calcular su puntaje total.
           
            El usuario ingresa la cantidad de obstáculos.
           
            Homero debe superar cada obstáculo y sumar los puntos correspondientes, cada obstáculo superado
            suma 10 puntos, cada obstáculo NO superado resta 5.
           
            (Debe aparecer un mensaje por cada obstáculo diciendo "OBSTACULO X, lo supera?" y
            el usuario debe responder si o no)*/
            Console.WriteLine("ingrese una cantidad de obstaculo ");
            int obstaculo = int.Parse(Console.ReadLine());
            int[] numobstaculo = new int[obstaculo];

            for (int cont = 0; cont < numobstaculo.Count(); cont++)

            {

                Console.WriteLine("obstaculo " + (cont + 1) + " lo supera?");
                string resp = Console.ReadLine();


                if (resp == "si")
                {
                    numobstaculo[cont] = 10;
                    Console.WriteLine(numobstaculo[cont]);
                }
                else if (resp == "no")
                {
                    numobstaculo[cont] -= 5;
                    Console.WriteLine(numobstaculo[cont]);
                }
                else
                {
                    Console.WriteLine("system error");
                    cont--;
                    
                }


               

            }

            int puntos = 0;

            for (int cont = 0; cont < numobstaculo.Count(); cont++)
            {
                puntos += numobstaculo[cont];
            }

            Console.WriteLine("puntos finales: " + puntos);
            Console.ReadKey();

        }
    }
}
