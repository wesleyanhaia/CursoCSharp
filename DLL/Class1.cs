using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
    /*/O primeiro passo pra criar um DLL é na hora de criar um projeto, pq a gente nao
     * cria um "Aplicativo do console" mas sim uma "Biblioteca de classes(.NET Framework)"
      * e pra criar é só selecionar biblioteca na ultima caixinha de opções da direita/*/
{
    public class Matematica /*/ Aparentemente um DLL é igual uma classe, onde colocamos varios códigos dentro
                             * e depois chamamos ela no program pra usar os codigos e comandos que estão la dentro.
                             * Para chamar uma DLL no program primeiro precisamos adicionar o namespace dela
                             * na parte das bibliotecas, no caso desta DLL em que estamos, seria using DLL;/*/
    {
        public static double Soma(double a, double b)
        {
            return a + b;
        }

        public static double Multiplica(double a, double b)
        {
            return a * b;
        }
    }
}