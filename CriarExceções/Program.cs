﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Como_criar_um_excecao

/*/ pra criar a nossa propria exceção nos precisamos criar uma classe que vai herdar da classe Exception
 * e se for ver a gente criou aí uma classe com o nome NumeroNegativoException/*/
{
    internal class Program
    {
        static void VerificaNumero(int numero)
        {
            if (numero < 0)
                throw new NumeroNegativoException(numero);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número positivo");
                int numero = Convert.ToInt32(Console.ReadLine());
                VerificaNumero(numero);
                Console.WriteLine("O número digitado é positivo");
            }
            catch (NumeroNegativoException e)
            {
                Console.WriteLine("Exceção específica: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção generica: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
        }
    }
}
