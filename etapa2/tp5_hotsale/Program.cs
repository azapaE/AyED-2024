using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5_hotsale
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("escriba la cantidad de productos vendidos");
            int prodVendidos = int.Parse(Console.ReadLine());
            int[] prod = new int[prodVendidos];
            for(int i = 0;i < prod.Count();i++)
            {
                Console.WriteLine("escriba el precio del producto N°"+(i + 1));
                int costo = int.Parse(Console.ReadLine());
                prod[i] = costo;
            }
            for(int i = 0; i < prod.Count()-1; i++)
            {
                for(int j = 0; j < prod.Count()-1-i;i++)
                {
                    if(prod [j]< prod[j + 1])
                    {
                        int temp = prod[j];
                        prod[j] = prod[j + 1];
                        prod[j + 1] = temp;
                    }
                }

            }
            for (int i = 0; i < prod.Count();i++)
            {
                Console.WriteLine("" + prod[i] + "$");
          }
            Console.WriteLine("el producto mas caro es: " + prod[0]);
            Console.WriteLine("el producto mas economico es : " + prod[prod.Count() - 1]);


            Console.ReadKey();
        }
    }
}