using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança
{
    internal class Carro : Veiculo
    {
        public void Acelerar(int pVelocidade)
        {
            if (EstaLigado == true)
            {
                Console.WriteLine("Carro acelerando");
                Velocidade = pVelocidade;
                Console.WriteLine($"Velocidade do carro: {Velocidade}");
            }
            else
            {
                Console.WriteLine("O carro esta desligado");
            }
        }
            public void Brecar()
            {
                Console.WriteLine("Carro brecando");
                Velocidade = 0;
            Console.WriteLine($"Velocidade do carro : {Velocidade}");
            }

            public Carro(int pNumeroRodas, int pNumeroPortas): base(pNumeroRodas, pNumeroPortas)
            {

            }

    }
}
