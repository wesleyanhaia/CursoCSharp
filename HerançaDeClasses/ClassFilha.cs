using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_de_classes
{
    internal class ClasseFilha : ClasseMae //aqui ta o exemplo direto de como a filha herdou da mãe
                                           //é só colocar os dois pontos e o nome da classe que quer herdar
                                           //(pegar os codigos que tem la dentro)/*/
    {
        public string atributoDaFilha = "Atributo da filha";
        public string PropriedadeDaFilha
        {
            set;
            get;
        }
        public void MetodoDaClasseFilha()
        {
            Console.WriteLine("Método da classe filha");
        }
        public ClasseFilha() : base("akljghdkjHAGSDKjhgdkhA")
        {
            PropriedadeDaFilha = "Propriedade da filha";
        }
    }
}
