using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulacao_de_arquivos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "teste.txt";
            FileStream fs = File.Create(caminho); // O FileStream e o File.Create sempre
                                                  // estão juntos quando é pra criar um arquivo.
            
            fs.Close(); //tem que colocar esse .Close() no fim de cada
                        // criação de arquivo pra dar tudo certo.
            
            
            // Como não foi colocado um lugar pro arquivo ser criado,
            // ele vai aparecer na mesma pasta do executavel
            
            
            StreamWriter sw = new StreamWriter(caminho); // O StreamWriter vai escrever
                                                         // dentro do arquivo criado,q está dentro
                                                         // da variável "caminho"
            sw.Write('a');
            sw.Write('-');
            sw.Write("Olá mundo!\r\n");
            sw.Write("b-Olá mundo 2!\r\n");

            sw.WriteLine("c-Olá mundo 3!");
            sw.WriteLine("d-Olá mundo 4!");

            sw.Close(); /*/ No fim do StreamWriter precisamos usar o .close tambem/*/

            StreamReader sr1 = new StreamReader(caminho);

            char[] buffer = new char[128]; /*/quando for um char tipo caractere tem que usar esse metodo de buffer,
                                            * o primeiro numero é o indice que vai comecar a ler, e o segundo
                                            * numero é a quantidade de caracteres a serem lidos./*/
            sr1.Read(buffer, 4, 5); /*/ Pra ver caracteristicas do que está sendo lido, é só dar um break
                                     * point e dps clicar em cima do buffer e dps em exibir 
                                     * (lembrando que a linha do break point não é executada
                                     * apenas oq está antes do break point/*/
                                    
            sr1.Read(buffer, 8, 7);
            sr1.Close();

            StreamReader sr2 = new StreamReader(caminho);/*/ Aqui foi selecionado dnv a variavel
                                                          * "caminho" sem o link do repositorio, e 
                                                          * o comando StreamReader está dentro
                                                          * de outra variavel : "sr2"/*/

            string linha = sr2.ReadLine(); /*/Aqui ele vai ler uma linha atraves do ReadLine
                                            * e vai jogar essa leitura dentro da variavel "linha"/*/
            linha = sr2.ReadLine();/*/ Aqui parece que é a mesma coisa do codigo de cima né?
                                    * mas é que como o comando é ReadLine, ele pula uma linha
                                    * então o comando vai ler a segunda linha que está no 
                                    * arquivo de texto/*/
            sr2.Close();

            StreamReader sr3 = new StreamReader(caminho);
            string arquivoInteiro = sr3.ReadToEnd(); /*/Esse comando "ReadToEnd" le todo o conteudo
                                                      * dentro do arquivo do texto/*/
            sr3.Close();

        }
    }
}
