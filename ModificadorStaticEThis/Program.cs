﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorStaticEThis
{
    //Modificador static (estático ou fixo) - Ele é sempre usado após o modificador de acesso
    //O static transforma o que está sendo modificado por ele em pertencente à classe e não mais ao objeto.
    //Pode ser usado
    //atributo
    //propriedade
    //método
    //struct
    //classe
    //...

    //Não tem nada estático na classe Pessoa
    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public void ImprimeNome()
        {
            Console.WriteLine("O nome é: " + nome);
        }
        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }
    //A classe claculadora possui o modificador static
    public class Calculadora
    {
        public static double PI = 3.1415;
        public static double CalculaAreaCircunferencia(double pRaio)
        {
            return PI * Math.Pow(pRaio, 2);
        }
    }

    //Palavra this (este) - è utilizado para se referir àquilo que pertence a nossa classe
    public class MinhaPessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public void ImprimeNome()
        {
            Console.WriteLine("O nome é: " + nome);
        }
        public MinhaPessoa(string nome)
        {
            this.nome = nome; 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("João");
            Pessoa pessoa2 = new Pessoa("Pedro");
            pessoa1.ImprimeNome();
            pessoa1.Nome = "Maria";


            Console.WriteLine("O valor de PI é: " + Calculadora.PI); /*/Quando um atributo, propriedade ou metodo
                                                                      * de uma classe for static não vai ser
                                                                      * possível acessar essas informações
                                                                      * ao criar um objeto, ou seja, temos que
                                                                      * chamar a propria classe seguido de um ponto
                                                                      * e depois selecionar o atributo, propriedade ou
                                                                      * método que deseja usar. foi isso que aconteceu 
                                                                      * ao lado, foi chamado a classe Calculadora
                                                                      * para utilizar o atributo PI/*/
            Console.WriteLine("A área é: " + Calculadora.CalculaAreaCircunferencia(2));

            //Não podemos acessar o que é static através do nome do objeto, pois ele pertence à classe
            Calculadora calc = new Calculadora();/*/ aqui é só um exemplo tentando acessar o atrubuto da classe
                                                  * através de um objeto/*/


        }
    }
}
