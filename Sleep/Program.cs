using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sleep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                /*/é assim que chamamos o comando sleep, aqui nós queremos que o comando abaixo
                 * imprima a mensagem a cada 1 segundo, então precisamos especificar isso dentro
                 * do código do sleep em milisegundos, que nesse caso 1 segundo é oq vale 1000 milisegundos/*/
                Console.WriteLine("Passou 1 segundo");
            }
            Console.ReadKey();
        }
    }
}
