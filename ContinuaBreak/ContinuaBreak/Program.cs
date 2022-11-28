using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace VetoresArrays
{
    class program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pressione C para continuar");
                Console.WriteLine("Pressione B para break");

                char tecla = Console.ReadKey(true).KeyChar;

                if (tecla == 'c' || tecla == 'C') 
                {
                    continue;
                }

                else if (tecla == 'B' || tecla == 'b')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("TECLA DESCONHECIDA");
                }
                Console.WriteLine("Pressione qualque tecla para continuar");
                Console.ReadKey();
            }
            Console.WriteLine("Pressiona qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}