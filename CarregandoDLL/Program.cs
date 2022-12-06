using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;

namespace Carregando_DLL_no_projeto
{
    internal class Program
    {
        static void Main(string[] args) 

            /*/Para carregar a DLL no program eu cliquei com o botão direito em cima de referencias, que está
             * localizado no grenciador de soluções, depois eu cliquei em adicionar referencia, depois fui em
             * procurar, e tive que encontrar o debug da minha DLL que no caso foi facil pq ta tudo sendo
             * salvo dentro da pasta do Curso# (Lembrando que eu tive que compilar a DLL sem executar ela,
             * que dai ela cria esse arquivo que eu coloco aqui no program como referencia/*/

        {
            Console.WriteLine("A soma de 5 e 6 é: " + Matematica.Soma(5, 6)); 

            /*/Essas duas funções que foram chamadas (a de somar e a de multiplicar) estão dentro da
             * DLL é bom notar que elas foram chamadas através da classe que também está dentro da DLL
             * é como se a DLL fosse uma extenção do arquivo principal/*/


            Console.WriteLine("A multiplicação de 5 e 6 é: " + Matematica.Multiplica(5, 6));

            Console.ReadKey();
        }
    }
}