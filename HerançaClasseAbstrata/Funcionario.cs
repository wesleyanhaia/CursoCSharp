using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaClasseAbstrata
{
    internal class Funcionario: Pessoa // a classe uncionario ta herdando a classe abstrata Pessoa,
                                       // por isso terá acesso aos comandos feitos dentro dela/*/
    {
        private int salario;

        public int Salario
        {
            get { return salario; }
            set { salario = value; }    
        }

        public void MostraSalario()
        {
            Console.WriteLine($"O salário do funcionário {Nome} é {Salario}");
        }

        public Funcionario(string pNome, int pSalario): base(pNome)
        {
            Salario = pSalario;

        }

    }
}
