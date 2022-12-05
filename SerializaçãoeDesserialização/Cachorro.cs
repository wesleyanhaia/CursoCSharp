using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization; /*/Eu cliquei em projeto e adicionei uma referencia,
                                     * e procurei o System.Runtime.Serialization e marquei a caixinha pra
                                     * selecionar, aí apareceu essemonte de coisa embaixo da referencia
                                     * no gerenciador de soluções. Tem que colocar manualmente a biblioteca 
                                     * ao lado "using System.Runtime.Serialization;"/*/



namespace Serializacao_e_desserializacao
{
    [DataContract] /*/ Para serializar uma classe tem que escrever esse comando ao lado [DataContract],
                    * ou seja, esse comando vai sinalizar que essa classe vai ser serializada /*/
    internal class Cachorro
    {
        [DataMember] /*/E devemos fazer essa serialiacao nos membros da classe tambem, escrevendo esse
                          * comando [DataMember] /*/
        public string Nome { get; set; }
        [DataMember]
        public string raca;
        [DataMember]
        private string cor;
        public Cachorro(string pNome, string pRaca, string pCor)
        {
            Nome = pNome;
            raca = pRaca;
            cor = pCor;
        }
        public Cachorro() /*/ isso aqui é um contrutor padrão, ele não possui nenhum parametro/*/
        {

        }
    }
}
