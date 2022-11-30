using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_de_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClasseFilha objFilha = new ClasseFilha();
            objFilha.MetodoDaClasseFilha();
            objFilha.MetodoDaClasseMae(); /*/Como a ClasseFilha herdou as funções dentro da ClasseMãe, 
                                           * se eu chamar a função da ClasseFilha no main() ela automaticamente 
                                           * vai executar tudo que está na classe mãe e filha/*/                                           
                                          

            Console.WriteLine(objFilha.atributoDaMae);
            Console.WriteLine(objFilha.PropriedadeDaMae);
            Console.ReadKey();
        }
    }
}
