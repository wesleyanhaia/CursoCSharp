﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_excecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");



            try//(Tentar) Obrigatório - Sempre será executado
            {
                int i = Convert.ToInt32(Console.ReadLine());
                int resultado = 10 / i;
                Console.WriteLine("Resultado da divisão: " + resultado);
            }
            catch (DivideByZeroException oioi/*Tipo da exceção a ser gerenciada/tratada*/)//(Pegar) Obrigatório - Só é executado em caso de exceção
            {
                Console.WriteLine($"Exceção: {oioi.Message}");
            }
            catch (Exception oioi)
            {
                Console.WriteLine("Exceção genérica: " + oioi.Message);
            }
            finally//(Finalmente)Opcional - Sempre será executado
            {
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }
        }
    }
}