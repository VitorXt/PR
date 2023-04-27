using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_3Periodo.Atividades.Atividade01
{
    internal class AnalisaVirus
    {
        public void AnalisarVirus()
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("\nQual o nome do vírus?");
                string nomeVirus = Console.ReadLine();

                switch (nomeVirus)
                {
                    case "Covid":
                        {
                            Console.Write("\nQuantos serão os dias de quarentena? ");
                            int totalDias = Convert.ToInt32(Console.ReadLine());

                            Covid _covid = new Covid(totalDias);
                            _covid.Nome = nomeVirus;

                            _covid.ImprimirRecomendacoesTratamento();

                            Console.WriteLine("\nDeseja fazer uma observação? s/n");
                            char observacao = char.ToLower(Convert.ToChar(Console.ReadLine()));

                            if (observacao == 's')
                            {
                                Console.WriteLine("\nQual a observação a ser feita?");
                                _covid.Observacao = Console.ReadLine();
                            }

                            break;
                        }
                    case "H1N1":
                        {
                            H1N1 _h1N1 = new H1N1();
                            _h1N1.Nome = nomeVirus;

                            _h1N1.ImprimirRecomendacoesTratamento();

                            Console.WriteLine("\nDeseja fazer uma observação? s/n");
                            char observacao = char.ToLower(Convert.ToChar(Console.ReadLine()));

                            if (observacao == 's')
                            {
                                Console.WriteLine("\nQual a observação a ser feita?");
                                _h1N1.Observacao = Console.ReadLine();
                            }
                            break;
                        }
                }

                Console.WriteLine("\nDeseja finalizar? s/n");
                char sair = char.ToLower(Convert.ToChar(Console.ReadLine()));

                if (sair == 's')
                {
                    loop = false;
                }
            }    
        }
    }
}
