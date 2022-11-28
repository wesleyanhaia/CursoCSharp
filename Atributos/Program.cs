using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    public class Carro
    {
        //MODIFICADOR_DE_ACESSO TIPO_DO_ATRIBUTO NOME_DO_ATRIBUTO
        //Modificadores
        //public (público) - Todos podem acessar o nosso atributo/variável
        //private  (privado) - Somente a nossa classe poderá acessar o atributo

        //Criando atributo
        public string marca;
        private double velocidade; /*/ como esse atributo é privado, ele só ira funcionar dentro da classe 
                                    * criada, não poderá ser acessado e nem modificado fora dela/*/

        public void ConfiguraVelocidade(double VelocidadeFinal)
        {
            velocidade = VelocidadeFinal;
            marca = "Fiat";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.marca = "Honda"; /*/para acessar uma classe atraves de um objeto é só chamar o objeto 
                                       * seguido de um ponto para acessar atributos, propriedades e até metodos
                                       * dentro da classe/*/
            
            
        }
    }
}