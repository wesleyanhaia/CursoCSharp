using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ManipulaçãoDeArquivos
    {
        internal class Program
        {
            static void Main(string[] args)
            {

            string caminho1 = "C:\\Users\\unesclabs102\\source\\repos\\ManipulaçãoDeArquivos\\ManipulaçãoDeArquivos\\bin\\Debug\\testando.txt";

                FileStream meuArquivo = File.Create(caminho1);
                meuArquivo.Close();

            string conteudo = "Wesley Anhaia da Silva";
            File.WriteAllText(caminho1, conteudo);
            

            string[] conteudoVetor = { "Wesley", "Douglas", "Davi", "Amanda" };
            File.WriteAllLines(caminho1, conteudoVetor);

        }

        }
    }
