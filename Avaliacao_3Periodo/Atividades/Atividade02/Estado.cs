using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_3Periodo.Atividades.Atividade02
{
    internal class Estado
    {
        List<Cidade> listaCidade = new List<Cidade>();

        public void CadastrarCidade()
        {
            Console.Write("\nQuantas cidade serão cadastradas? ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"\nQual o nome da {i + 1}° cidade? ");
                string nomeCidade = Console.ReadLine();

                Console.Write($"Qual a população da {i + 1} cidade? ");
                int populacao = Convert.ToInt32(Console.ReadLine());

                Cidade _cidade = new Cidade(nomeCidade, populacao);

                listaCidade.Add(_cidade);
            }
        }

        public void ImprimirCidade()
        {
            foreach (Cidade item in listaCidade)
            {
                Console.WriteLine($"\nCidade: {item.Nome}");
                Console.WriteLine($"População: {item.Populacao} habitantes");
            }
        }

        public Cidade LocalizarCidadeMaiorPopulacao()
        {
            List<Cidade> ordenarCidade = listaCidade.OrderByDescending(cidade => cidade.Populacao).ToList();

            Cidade cidadeMaisPoupulosa = ordenarCidade[0];

            return cidadeMaisPoupulosa;
        }
    }
}
