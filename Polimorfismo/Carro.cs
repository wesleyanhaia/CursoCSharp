using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Carro: Veiculo
    {
       override public void Anda()
        {
            base.Anda(); /*/ quando é utilizado o comando "base" ele está se referindo a Classe mãe
                          * ou seja, aqui ele vai chamar a função Anda() da classe mãe ue vai executar
                          * a impressão "O veiculo está andando" antes do "O carro está andando" 
                          * que está logo abaixo/*/
            Console.WriteLine("O carro está andando");
        }
         
    }
}
