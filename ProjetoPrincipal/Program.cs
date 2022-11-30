using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o n´´umero do seu documento:  ");
            string documento = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua rua ");
            string nomedarua = Console.ReadLine();

            Console.WriteLine("Digite o numero da sua casa");
            int numerodacasa = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu genero, F para feminino e M para masculino: ");
            string genero = Console.ReadKey().KeyChar.ToString();

            Console.WriteLine($"Olá {nome}");
            Console.WriteLine($"Você tem {idade} anos de idade");
            Console.WriteLine($"O numero do seu documento é {documento}");
            Console.WriteLine($"O nome da sua rua é {nomedarua}");
            Console.WriteLine($"O numero da sua casa é {numerodacasa}");
            Console.WriteLine($"O seu genero é {genero}");

            Console.ReadKey();


        }
    }
}
