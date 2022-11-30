using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaClasseAbstrata
{ 

    //modificador abstract
    /*/A classe com o modificador abstract só poderá ser herdada, 
     * ou seja nao da pra criar um objeto dessa classe/*/ 


    internal class Pessoa // é só escrever "abstract" na frente de class
    {
        public string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public void MostraNome()
        {
            Console.WriteLine($"O nome da pessoa é: {nome}");
        }
        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }
}
