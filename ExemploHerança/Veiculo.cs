using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança
{
    internal class Veiculo
    {
        private int numeroRodas; /*/ os atributos(variaveis) é bom sempre deixar private, é as propriedades
                                  * no public. As propriedades são o manueseio dos atributos, e esse manuseio
                                  * está acontecendo logo abaixo com get e set, mas poderia acontecer com qualquer
                                  * outro tipo de comando. É bom observar que o nome de cada propriedade tem o nome
                                  * parecido(mas nao igual) com os atributos Ex: atributo numeroRodas e propriedade
                                  * NumeroRodas/*/
        private int numeroPortas;
        private int velocidade;
        private bool estaLigado;

        public int NumeroRodas
        {
            get { return numeroRodas; } /*/ nao tem "SET" pois o numero de rodas
                                         * geralmente não se altera ne kkkk/*/
        }
        public int NumeroPortas
        {
            get { return numeroPortas;  }
        }
        public int Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        public bool EstaLigado
        {
            get { return estaLigado; }
        }
        public void Ligar()
        {
            Console.WriteLine("Veículo ligado");
            estaLigado = true;
        }
        public void Desligar()
        {
            Console.WriteLine("Veículo desligado");
            estaLigado = false;
        }

        public Veiculo(int pNumeroRodas, int pNumeroPortas) /*/Isso aqui é o construtor/*/
        {
            this.numeroRodas = pNumeroRodas;
            this.numeroPortas = pNumeroPortas;
            velocidade = 0;
            estaLigado = false;

        }


    }
}
