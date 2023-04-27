using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_3Periodo.Atividades.Atividade01
{
    internal class H1N1 : Virus
    {
        public override void ImprimirRecomendacoesTratamento()
        {
            Console.WriteLine("\nQual a variação?");
            string possuiVariacao = Console.ReadLine();

            string variacao = AnalisarVariacao(possuiVariacao);

            Console.WriteLine(variacao);
        }

        public string AnalisarVariacao(string variacao)
        {
            if (variacao == "AAA")
            {
                return "\nFicar em casa por 5 dias";
            }
            else
            {
                return "\nPode trabalhar e usar máscara";
            }
        }
    }
}
