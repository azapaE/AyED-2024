using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Vectorrandomswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*El objetivo de este ejercicio es crear un programa que utilice un vector, números aleatorios generados
            con la función Random y una estructura de control switch para realizar las siguientes acciones:
            1)  Se crea un vector de tamaño n, donde n es un valor ingresado por el usuario.
            2)  Se utiliza la función Random para generar números aleatorios entre un rango definido y
            se llenan las posiciones del vector con estos valores.
            3)  Se presenta al usuario un menú con las siguientes opciones:
            Imprime en pantalla todos los elementos del vector.
            El usuario ingresa un número y el programa busca si este se encuentra en el vector. Si lo encuentra,
            se indica la posición en la que se encuentra.
            Se ordena el vector de forma ascendente o descendente, según la elección del usuario.
            Termina la ejecución del programa.
            El programa utiliza la estructura de control switch para evaluar la opción seleccionada por el usuario y
            ejecutar la acción correspondiente.*/
            Console.WriteLine("escriba un valor para el vector");
            int n = int.Parse(Console.ReadLine());
            int[] vect = new int[n];
            Random aleatoria = new Random();
            for (int i = 0; i < vect.Count();i++)
            {
                vect[i] = aleatoria.Next(0, 10);
            }
            Console.WriteLine("\nseleccione una opcion");
            Console.WriteLine("1. terminar todos los elementos del vector");
            Console.WriteLine("2. buscar un numero en el vector");
            Console.WriteLine("3. ordenar el vector");
            Console.WriteLine("4. terminar la ejecucion del programa");

            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("elementos del vector:");
                    for(int i = 0;i< vect.Count();i++)
                    {
                        Console.WriteLine(vect[i]);
                      
                    }
                    break;
                case 2:
                    Console.WriteLine("ingrese el numero de casillo que quiere buscar em el vector");
                    int num = int.Parse(Console.ReadLine());
                    for (int i = 0; i < vect.Count(); i++)
                    {
                        if (num == vect[i])
                        {
                            Console.WriteLine("el valor q esta en la casilla" + i +"del vector");

                        }
                        else
                        {
                            Console.WriteLine("el valor no esta en el vector");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("como quiere q se ordene el vector de manera" "acendente" "o" "desendente");
                    string orden = (Console.ReadLine());
                    if (orden == "acendente")
                    {
                        for (int i = 0; i < vect.Count()-1; i++)
                        {

                        }
                    }








            }


























            Console.ReadKey();
        }
    }
}
