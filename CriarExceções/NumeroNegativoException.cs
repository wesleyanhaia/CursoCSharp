using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Como_criar_um_excecao
{
    public class NumeroNegativoException : Exception
        /*/Aqui nós fizemos a nossa classe herdar a classe Exception, pode parecer estranho pq a gente não 
         * criou essa classe né? Mas a classe Exception meio que ja está dentro do sistema ´por ser um comando
         * pronto./*/
    {
        public NumeroNegativoException(int numero) : base("Número " + numero + " não é positivo")
        {

        }
    }
}