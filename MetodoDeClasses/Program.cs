﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Metodos_de_classes
{
    public class ContaBancaria
    {
        //atributos
        private double saldo;
        private string senha;
        private string nomeDoCliente;

        //Métodos(função) como é a estrutura para fazer um:
        //ModificadorDeAcesso TipoDeSaída NomeDoMetodo (TipoDaVariavel1 NomeVariavel1, TipoDaVariavel2 NomeVariavel2, ...)
        //{
        //  CONTEÚDO_DO_MÉTODO
        //  return VALOR_DE_SAÍDA;
        //}

        //MODIFICADOR_DE_ACESSO
        //public (público) - Todos podem acessar o nosso métodos
        //private  (privado) - Somente a nossa própria classe pode acessar o método

        //TIPO_DE_SAÍDA
        //EXEMPLO: int, string, bool, class, List....

        //PARÂMETROS_DE_ENTRADA
        //TIPO_PAR: int, string, class, List....
        //NOME_PAR: 

        public double Sacar(double pValorSacado, string pSenha) /*/La no main() quando o metodo sacar for chamado
                                                                 * o primeiro valor sera o dinheiro q quer sacar
                                                                 * e o segundo será a senha dai ficou mais ou menos assim
                                                                 * double valorSacado = contaDoPedro.Sacar(10, "12345"); 
                                                                 * explicando oq aconteceu foi: contaDoPedro é um objeto que 
                                                                 * acessou a classe e puxou a função Sacar colocando a quantia
                                                                 * e a senha, depois essa quantia foi jogada na variavel valorSacado/*/
        {
            if (senha == pSenha)
            {
                if (saldo > pValorSacado)
                {
                    saldo -= pValorSacado; // é igual a fazer assim --> saldo = saldo-pValorSacado;
                    Console.WriteLine("O valor sacado foi de: " + pValorSacado);
                    return pValorSacado;
                }
                else
                {
                    Console.WriteLine("O saldo é insuficiente");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("A senha está incorreta");
                return 0;
            }
        }

        public void Depositar(double pValorDepositado)
        {
            saldo += pValorDepositado; // é igual a fazer assim --> saldo = saldo+pValorSacado;
            Console.WriteLine("O valor depositado foi de: " + pValorDepositado);
        }

        public void Depositar(double pValorDepositado, string pNomeDoCliente)
        {
            if (pNomeDoCliente == nomeDoCliente)
            {
                saldo += pValorDepositado;
                Console.WriteLine("O valor depositado foi de: " + pValorDepositado);
            }
            else
            {
                Console.WriteLine("Depósito feito para a conta errada");
                return;
            }
        }

        public void ConsultaSaldo(string pSenha)
        {
            if (senha == pSenha)
                Console.WriteLine("O saldo da conta é: " + saldo);
            else
                Console.WriteLine("A senha está incorreta");
        }

        //Esse é o método construtor
        //Primeiro método a ser executado quando (instanciamos a classe)/(criamos um objeto)
        //Construtor não possui parâmetro de saída
        //O construtor sempre é público
        //Normalmente o construtor é usado para fazer as configurações iniciais do nosso objeto
        public ContaBancaria(string pSenha, string pNomedoCliente)
        {
            saldo = 0;
            senha = pSenha;
            nomeDoCliente = pNomedoCliente;
        }

        public ContaBancaria(double pSaldo, string pSenha, string pNomedoCliente)
        {
            saldo = pSaldo;
            senha = pSenha;
            nomeDoCliente = pNomedoCliente;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaDoPedro = new ContaBancaria("12345", "Pedro Santos");
            // contaDoPedro é um objeto(variavel) que vai acessar diretamente a classe ContaBancaria
            double valorSacado = contaDoPedro.Sacar(10, "12345");
            contaDoPedro.Depositar(1000);
            contaDoPedro.ConsultaSaldo("12345");
            valorSacado = contaDoPedro.Sacar(10, "12345");

            ContaBancaria contaDoJoao = new ContaBancaria(1000, "12345", "Joao da Silva");

        }
    }
}
