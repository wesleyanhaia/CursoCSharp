using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{ 
    public class Carro
    {
        //Atributos ou variáveis (atribustos são variaveis dentro de uma classe)
        private string marca;
        private string modelo; /*/ o modificador de acesso desses atributos são todos privados
                                * ou seja, só podemser acessados dentro da classe, então se eu 
                                * chamar no main() eles nao vão funcionar.Ja as PROPRIEDADES
                                * logo abaixo, podem ser acessadas no main() por serem publicas/*/
        private UInt32 velocidade;
        private bool carroLigado;

        //propriedades
        public string Marca /*/As propriedades são os comandos que vão alterar diretamente
                             * os atributos(variaveis dentro de uma classe), uma propriedade
                             * precisa ter o mesmo tipo do atributo (nesse caso string)/*/
        {
            get { return marca; }
            set { marca = value; } // set vai atribuir um valor pro atributo "marca"
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public UInt32 Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        public bool CarroLigado
        {
            get { return carroLigado; }
            set { carroLigado = value; }
        }

        //métodos
        public void LigarCarro()
        {
            carroLigado = true;
            Console.WriteLine("Ligando o carro da marca " + marca + " e do modelo " + modelo);
        }
        public void DesligarCarro()
        {
            carroLigado = false;
            Console.WriteLine("Desligando o carro da marca " + marca + " e do modelo " + modelo);
        }
        public void AcelerarCarro(UInt32 velocidadeFinal)
        {
            if(carroLigado == true)
            {
                velocidade = velocidadeFinal;
                Console.WriteLine("A velocidade do carro da marca " + marca + " e do modelo " + modelo + " é " + velocidade);
            }
            else
            {
                Console.WriteLine("O carro da marca " + marca + " e do modelo " + modelo + " esta desligado ");
            }
        }
        public void PararCarro()
        {
            if(velocidade == 0)
            {
                Console.WriteLine("O carro da marca " + marca + " e do modelo " + modelo + " já esta parado ");
            }
            else
            {
                velocidade = 0;
                Console.WriteLine("O carro da marca " + marca + " e do modelo " + modelo + " esta parado ");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro hondaFit = new Carro(); /*/ Aqui foi criado o objeto hondaFit. Um objeto nada mais
                                          * é que uma constante que acessa tudo que está dentro de
                                          * uma classe, e nesse caso se chamar o objeto seguido de
                                          * um ponto, podemos acessar os atributos, propriedades e
                                          * até os métodos presentes na classe Carro() que foi criada
                                          * no início do programa/*/
            hondaFit.Marca = "Honda";
            hondaFit.Modelo = "FIT";
            hondaFit.LigarCarro();
            hondaFit.AcelerarCarro(80);
            hondaFit.PararCarro();
            hondaFit.DesligarCarro();

            Carro fiatUno = new Carro(); /*/ aqui foi criado novamente outro objeto que acessa
                                          * diretamente a classe Carro()/*/
            fiatUno.Marca = "Fiat";
            fiatUno.Modelo = "Uno";
            fiatUno.AcelerarCarro(80);
            fiatUno.LigarCarro();
            fiatUno.AcelerarCarro(80);
            fiatUno.PararCarro();
            fiatUno.DesligarCarro();

            Console.ReadKey();
        }
    }
}