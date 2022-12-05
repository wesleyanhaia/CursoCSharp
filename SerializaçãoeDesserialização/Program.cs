using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization; /*/Aqui no program, foi adicionado 3 bibliotecas são essas: using System.Xml;
                                     * using System.IO; e using System.Runtime.Serialization;/*/

namespace Serializacao_e_desserializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro("Bilu", "Boxer", "Marrom");
            Cachorro meuCachorroDesserializado;

            DataContractSerializer serializador = new DataContractSerializer(typeof(Cachorro));

            //Serialização

            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };
            /*/Esse objeto que criamos acima, é um que vai usar as configurações de escrita do xml
             * que é tipo pra deixar as coisas organizadas, um exemplo é as chaves que a gente abre 
             * aqui do lado esquerdo e elas ficam alinhadas no código./*/

            StringBuilder construtorDeString = new StringBuilder();
            /*/Esse StringBuilder vai pegar o conteudo do xml e transformar numa string /*/

            XmlWriter ecritorDeXml = XmlWriter.Create(construtorDeString, xmlConfig);
            /*/ Esse XmlWriter é basicamente um "escritor de xml" que vai usar as configurações
             * que colocamos entre parenteses/*/

            serializador.WriteObject(ecritorDeXml, meuCachorro);
            /*/Esse codigo assima vai pegar o conteudo do objeto meuCachorro e transformar num conteúdo xml
             * e por fim o ecritorDeXml vai transformar o conteudo em uma string/*/

            ecritorDeXml.Flush();
            /*/O flush é pra dizer que ja foi concluido a transformação do objeto em xml/*/

            string objetoSerializadoStr = construtorDeString.ToString();
            /*/Aqui ele transformou o conteudo dentro do construtorDeString em uma string e jogou isso tudo
             * dentro dessa outra variável objetoSerializadoStr /*/

            //Salvando o conteúdo do objeto num XML
            string caminhoDoMeuArquivoXml = "cachorro.xml";
            FileStream meuArquivoXml = File.Create(caminhoDoMeuArquivoXml);
            meuArquivoXml.Close();
            File.WriteAllText(caminhoDoMeuArquivoXml, objetoSerializadoStr);

            //Desserialização
            string conteudoDoObjetoSerializado = File.ReadAllText(caminhoDoMeuArquivoXml);
            StringReader leitorDeStrings = new StringReader(conteudoDoObjetoSerializado);
            XmlReader leitorDeXml = XmlReader.Create(leitorDeStrings);
            meuCachorroDesserializado = (Cachorro)serializador.ReadObject(leitorDeXml);

            ecritorDeXml.Close();
            leitorDeXml.Close();

        }
    }
}
