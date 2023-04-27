using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_3Periodo.Atividades.Atividade01
{
    internal class Covid : Virus
    {
        public int TotalQuarentenaDias { get; set; }

        public Covid(int TotalQuarentenaDias)
        {
            this.TotalQuarentenaDias = TotalQuarentenaDias;
        }

        public override void ImprimirRecomendacoesTratamento()
        {
            Console.WriteLine($"\nVocê está com {Nome}. O seu retorno para o trabalho será dia {CalcularDataRetorno()}");
        }

        public DateTime CalcularDataRetorno()
        {
            return DateTime.Today.AddDays(TotalQuarentenaDias);
        }
    }
}
