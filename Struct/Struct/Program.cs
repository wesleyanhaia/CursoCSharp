using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        struct Cadastro
        {
            public string nome;
            public int numero;
        }
        static void Main(string[] args)
        {
            Cadastro exemplo;
            exemplo.nome = "wesley";
            exemplo.numero = 54;

            Console.WriteLine($"meu nome é {exemplo.nome} e eu tenho {exemplo.numero} anos");
            Console.ReadKey();
        }
    }
}
