using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_3Periodo.Atividades.Atividade01
{
    abstract class Virus
    {
        public string Nome { get; set; }
        public string Observacao { get; set; }

        public virtual void ImprimirRecomendacoesTratamento()
        {

        }
    }
}
