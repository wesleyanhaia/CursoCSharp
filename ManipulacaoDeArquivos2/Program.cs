using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulacao_de_arquivos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string caminhoArquivo2 = @"C:\Users\unesclabs102\Desktop\C#\1- Curso C#\ManipulaçãoDeArquivos 2\ManipulaçãoDeArquivos\bin\Debug\teste1.txt";
            string texto1 = "João subiu no telhado. \r\n";
            string texto2 = "Luana, sua mãe, brigou com ele. \r\n";

            /*/ Aqui o comando File.AppendAllText vai juntar o texto1 e texto2 e vai enviar para 
            o arquivo de texto pelo link do repositório que está dentro da variavel caminhoArquivo2 /*/
            File.AppendAllText(caminhoArquivo2, texto1 + texto2);

            /*/Obs: O AppendAllText vai deixar salvo no arquivo de texto todas as vezes
              que eu executar o programa, entao se eu executar o arquivo 3 vezes, vai ter
              3 vezes escrito a mesma coisa no arquivo de texto/*/

            /*/Ja o WriteAllText nunca deixa salvo o texto dentro do arquivo /*/

        }
    }
}