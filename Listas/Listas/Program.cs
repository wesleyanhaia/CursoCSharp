using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaDeNumeros = new List<int>();

            ListaDeNumeros.Add(0);
            ListaDeNumeros.Add(1);
            ListaDeNumeros.Add(2);
            ListaDeNumeros.Add(3);

            foreach (int i in ListaDeNumeros)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine($"a lista de numero tem { ListaDeNumeros.Count} elementos");
            Console.ReadKey();


            //pra baixo eu to fazendo o ngc de remove range



            List<int> ListaDeNumeros2 = new List<int>();

            ListaDeNumeros2.Add(10);
            ListaDeNumeros2.Add(100);
            ListaDeNumeros2.Add(200);
            ListaDeNumeros2.Add(300);

            ListaDeNumeros2.RemoveRange(0, 2);

            foreach (int w in ListaDeNumeros2)
            {
                Console.WriteLine(w);

            }
            
            Console.ReadKey();
        }
    }
}
