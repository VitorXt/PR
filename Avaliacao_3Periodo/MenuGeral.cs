using Avaliacao_3Periodo.Atividades.Atividade01;
using Avaliacao_3Periodo.Atividades.Atividade02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_3Periodo
{
    internal class MenuGeral
    {
        public static void Menu()
        {
            bool loopMenu = true;

            while (loopMenu)
            {
                Console.WriteLine("\nEscolha:\n");
                Console.WriteLine("\n1 - Atividade 1" + "\n2 - Atividade 2" + "\n3 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            AnalisaVirus analisaVirus = new AnalisaVirus();
                            analisaVirus.AnalisarVirus();
                            break;
                        }
                    case 2:
                        {
                            Estado _estado = new Estado();

                            bool loop = true;

                            while (loop)
                            {
                                Console.WriteLine("\nQual opção deseja escolher?\n");

                                Console.WriteLine("\n1 - Cadastrar Cidade" + "\n2 - Listar cidades" + "\n3 - Cidade com maior população" + "\n4 - Sair");
                                int escolha = Convert.ToInt32(Console.ReadLine());

                                if (escolha == 1)
                                {
                                    _estado.CadastrarCidade();
                                }
                                else if (escolha == 2)
                                {
                                    _estado.ImprimirCidade();
                                }
                                else if (true)
                                {
                                    Cidade maiorPopulacao = _estado.LocalizarCidadeMaiorPopulacao();

                                    Console.WriteLine($"\nA cidade com maior Pupulação é: {maiorPopulacao.Nome} com {maiorPopulacao.Populacao} habitantes");
                                }
                                else
                                {
                                    loop = false;
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            loopMenu = false;
                            break;
                        }
                }
            }
            Console.WriteLine("\nFim do programa!");
        }
    }
}
