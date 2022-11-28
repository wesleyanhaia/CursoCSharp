using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoKeyChar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char opcao;

            Console.WriteLine("Digite um numero");
            opcao = Console.ReadKey().KeyChar; // Testando, pq u achava q esse keychar só funcionava pra letra

            if (opcao == 'a' || opcao == '1')
            {

                Console.WriteLine("\ntestando\n"); 
                Console.ReadKey();
            }
        }
    }
}
