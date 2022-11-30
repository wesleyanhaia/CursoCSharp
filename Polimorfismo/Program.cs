using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro objCarro = new Carro();
            Bicicleta objBicicleta = new Bicicleta();

            objCarro.Anda();     /*/Até esse momento do codigo não tinha nada nas classes carro e bicicleta
                                  * então as duas classes só herdaram mo metodo Anda() da classe mãe Veiculo
                                  * e executaram o código de impressão que está dentro do metodo./*/
            objBicicleta.Anda();

            Console.ReadKey(); /*/Explicação: Nesse exemplo de polimorfismo o carro e a bicileta estao
                                * chamando a função Anda(), mas se tu for ver, as 3 classes tem a mesma
                                * função dentro delas, porém, quando o objeto de carro por exemplo, chamar
                                * a função Anda() no main, ele não vai imprimir a mensagem da Classe mãe(que é:
                                * o veiculo está andando), e sim a mensagem dentro da classe filha(que
                                * é: o carro esta andando) MAAASSSSS não é simplesmente copiar a função que
                                * está na classe mãe e jogar na classe filha q isso vai funcionar, pra dar certo
                                * tem que escrever o comando "virtual" na frente do modificador de acesso da
                                * função da classe mãe e "override" na frente do modifcador de acesso da função das
                                * classes filhas que nesse caso são a bicicleta e o carro /*/
                                 


        }
    }
}
