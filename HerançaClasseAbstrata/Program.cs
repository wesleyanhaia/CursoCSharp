using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa minhPessoa = new Pessoa("João"); aqui foi tentado criar um objeto de uma classe
            //abstrata, coisa que não é possivel pois a classe abstrata só pode fazer heranças/*/

            Funcionario meuFuncionario = new Funcionario("João", 10000);
            meuFuncionario.MostraNome();
            meuFuncionario.MostraSalario();

            Console.ReadKey();

        }
    }
}
