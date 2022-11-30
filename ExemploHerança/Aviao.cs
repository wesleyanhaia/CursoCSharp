using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança
{
    internal class Aviao : Veiculo
    {
        private int altitude;

        public int Altitude
        {
            get { return altitude; }
        }
        public void Decolar(int pVelocidade, int pAltitude)
        {
            if (EstaLigado == true)
            {
                Console.WriteLine("Aviao decolando...");
                altitude = pAltitude;
                Velocidade = pVelocidade;
                Console.WriteLine($"A velocidade do avião é : {Velocidade}");
                Console.WriteLine($"A altitude do avião é : {Altitude}");


            }
            else
            {
                Console.WriteLine("Avião desligado");
            }
        }
            public void Pousar()
            {
               
                Console.WriteLine("Aviao pousando...");
                altitude = 0;
                Velocidade = 0;
                Console.WriteLine($"A velocidade do avião é : {Velocidade}");
                Console.WriteLine($"A altitude do avião é : {Altitude}");
                
               
            }
        public Aviao(int pNumeroRodas, int pNumeroPortas): base(pNumeroRodas, pNumeroPortas)
        {
            altitude = 0;


        }


    }
}
