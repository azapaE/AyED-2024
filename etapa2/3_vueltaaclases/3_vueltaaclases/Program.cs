using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_vueltaaclases
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Después de unas largas vacaciones llenas de aventuras, Phineas y
            Ferb regresan a la escuela. Sin embargo, como no estudiaron
            durante las vacaciones, necesitan un sistema que les ayude a 
            determinar si podrán aprobar la materia.
            El sistema debe permitir a Phineas y Ferb ingresar la cantidad de
            trabajos prácticos (TPs) y exámenes que tienen en la materia. 
            Luego, deben ingresar las notas de cada TP y examen.
            Para aprobar la materia, Phineas y Ferb deben cumplir dos condiciones:

            El promedio de las notas de los exámenes debe ser mayor o igual a 6.
            Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.

            El sistema debe calcular el promedio de los exámenes y verificar
            si se cumplen las condiciones para aprobar la materia. Finalmente, 
            debe mostrar en pantalla un mensaje indicando si Phineas y Ferb pueden
            aprobar la materia o no.

            Permitir al usuario especificar la cantidad de TPs y exámenes.
            Permitir al usuario ingresar las notas de cada TP y examen.
            Calcular el promedio de las notas de los exámenes.
            Verificar si se cumplen las condiciones para aprobar la materia.
            Mostrar un mensaje indicando si Phineas y Ferb pueden aprobar la materia*/

            Console.WriteLine("escriba la cantiad de TPs");
            int cantTPs = int.Parse(Console.ReadLine());
            int[] TPs = new int[cantTPs];
            for (int i = 0; i < TPs.Count(); i++)
            {
                Console.WriteLine("escriba la nota de los TPs");
                Console.WriteLine("trabajo practico N°" + (i + 1) + "\n" + "nota:");

                int notadetps = int.Parse(Console.ReadLine());
                if ((notadetps >= 1) && (notadetps <= 10))
                {
                    TPs[i] = notadetps;
                }
                else
                {
                    Console.WriteLine("/n" + "error,la nota debe ser entre el 1 hasta el 10" + "\n");
                    i--;
                }
            }


            Console.WriteLine("escriba la cantiad de examenes");
            int cantexamenes = int.Parse(Console.ReadLine());
            int[] exam = new int[cantexamenes];
            for (int i = 0; i < exam.Count(); i++)
            {
                Console.WriteLine("escriba la nota de los examenes");
                Console.WriteLine("trabajo practico n°" + (i + 1) + "\n" + "nota:");

                int notadeexam = int.Parse(Console.ReadLine());
                if ((notadeexam >= 1) && (notadeexam <= 10))
                {
                    exam[i] = notadeexam;
                }
                else
                {
                    Console.WriteLine();
                    i--;
                }
            }

            int tpsaprobados = 0;
            for (int i = 0; i < exam.Count(); i++)
            {
                if (TPs[i] >= 6)
                {
                    tpsaprobados ++;
                }
            }

            int totaldeexamnot = 0;

            for (int i = 0; i < exam.Count(); i++)
            {
                 totaldeexamnot += exam[i]; 
            }
            int notaTPs = (tpsaprobados * 100 / cantTPs);
            double promediosexam = (totaldeexamnot / cantexamenes);

            if (promediosexam >= 6 && notaTPs >= 75)
            {
                Console.WriteLine("phineas y ferb pueden aprobar la materia");
                Console.WriteLine("aprobo con el " + notaTPs + " % de los tps aprobados");
            }
            else
            {
                Console.WriteLine("phineas y ferb no pueden aprobar la materia");
                Console.WriteLine("desaprobo con el " + notaTPs + " % de los tps aprobados");
            }
            Console.WriteLine("promedios de las notas de los examenes "+ promediosexam);
            





            Console.ReadKey();

        }
    }
}
