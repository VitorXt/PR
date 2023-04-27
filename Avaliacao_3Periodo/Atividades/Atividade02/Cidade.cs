using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_3Periodo.Atividades.Atividade02
{
    internal class Cidade
    {
        public string Nome { get; set; }
        public int Populacao { get; set; }

        public Cidade(string nome, int populacao)
        {
            Nome = nome;
            Populacao = populacao;
        }
    }
}
