using System;

namespace ConsoleApp1.GestãoDeEquipamentos
{
    internal class Program
    {
        //crtl + . = metodo main 
        //string strx = Console.ReadLine();
        //Console.WriteLine("");
        static void Main(string[] args)
        {
            string[] nomesEquipamento = new string[1000];
            double[] precoEquipamento = new double[1000];
            string[] serieEquipamentos = new string[1000];
            string[] fabricanteEquipamento = new string[1000];
            string[] dataFabricaEquipamento = new string[1000];

            string[] nomeChamado = new string[1000];
            int[] posicaoEquipChamado = new int[1000];
            string[] descricao = new string[1000];
            int[] nID = new int[1000];
            string[] dataChamado = new string[1000];

            int c = 0;

            double dias;
            int posicaoEquipamento = 0;

            for (int i = 0; i < 1000; i++)
            {

                Console.WriteLine("Gestão de Equipamentos ");
                Console.WriteLine();

                Console.WriteLine("Digite [1] para Cadastrar novo Equipamento");
                Console.WriteLine("Digite [2] para Controlar Chamados");

                Console.WriteLine("Digite [S} para SAIR");

                string opcao = Console.ReadLine();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Gestão de Equipamentos ");
                    Console.WriteLine();

                    Console.WriteLine("Digite [1] para inserir novo equipamento ");
                    Console.WriteLine("Digite [2] para visualizar equipamentos ");
                    Console.WriteLine("Digite [3] para editar equipamentos ");
                    Console.WriteLine("Digite [4] para excluir um equipamento ");

                    Console.WriteLine("Digite [S] para sair");
                    string opcaosubmenu = Console.ReadLine();
                    if (opcaosubmenu == "s")
                        continue;

                    if (opcaosubmenu == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Gestão de Equipamentos");
                        Console.WriteLine();

                        Console.WriteLine("▓▓▓▓Inserir um novo Equipamento▓▓▓");
                        Console.WriteLine("====================================");
                        Console.Write("Digite o nome do Equipamento:   ");
                        string nome = Console.ReadLine();
                        nomesEquipamento[posicaoEquipamento] = nome;
                        Console.Write("Digite o preço do Equipamento:  ");
                        double preco = Convert.ToDouble(Console.ReadLine());
                        precoEquipamento[posicaoEquipamento] = preco;
                        Console.Write("Digite o número de série do Equipamento:  ");
                        string serie = Console.ReadLine();
                        serieEquipamentos[posicaoEquipamento] = serie;
                        Console.Write("Digite a data de fabricação do Equipamento:  ");
                        string data = Console.ReadLine();
                        dataFabricaEquipamento[posicaoEquipamento] = data;
                        Console.Write("Digite o fabricante do Equipamento:  ");
                        string fabricante = Console.ReadLine();
                        fabricanteEquipamento[posicaoEquipamento] = fabricante;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" \n Equipamento cadastrado com sucesso ☺ ");
                        Console.ResetColor();
                        posicaoEquipamento++;
                    }
                    else if (opcaosubmenu == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Gestão de Equipamentos");
                        Console.WriteLine();

                        Console.WriteLine("▓▓▓▓Visualizando Equipamentos▓▓▓");
                        Console.WriteLine("====================================");
                        for (int posicao = 0; posicao < 1000; posicao++)
                        {
                            if (nomesEquipamento[posicao] != null)
                            {
                                Console.WriteLine("Nome\t\t" + nomesEquipamento[posicao]);
                                Console.WriteLine("Preço\t\t" + precoEquipamento[posicao]);
                                Console.WriteLine("Nº de serie\t\t" + serieEquipamentos[posicao]);
                                Console.WriteLine("Data de Fabricação\t\t" + dataFabricaEquipamento[posicao]);
                                Console.WriteLine("Fabricante\t\t" + fabricanteEquipamento[posicao]);
                                Console.WriteLine();
                                Console.WriteLine("_______________________");
                                Console.WriteLine();
                            }
                        }


                    }
                    else if (opcaosubmenu == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("Manutenção de Equipamentos ");
                        Console.WriteLine();

                        Console.WriteLine("Editando Equipamentos:\n");

                        int editar;
                        Console.Write("Digite a posição do elemento que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());



                        Console.Write("Edite o nome do equipamento " + editar + ": ");
                        nomesEquipamento[editar] = Console.ReadLine();


                        Console.WriteLine();

                        Console.Write("Edite o preço de aquisição do equipamento " + editar + ": ");
                        precoEquipamento[editar] = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();

                        Console.Write("Edite o numero de série do equipamento " + editar + ": ");
                        serieEquipamentos[editar] = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Edite o dia de fabricação do equipamento " + editar + ": ");
                        dataFabricaEquipamento[editar] = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Edite o nome do fabricante " + editar + ": ");
                        fabricanteEquipamento[editar] = Console.ReadLine();

                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nEquipamento editado com sucesso :-)");
                        Console.ResetColor();
                    }

                    else if (opcaosubmenu == "4")
                    {

                        {

                            Console.WriteLine("Digite a posição do equipamento que deseja excluir: ");
                            int excluir = Convert.ToInt32(Console.ReadLine());
                            int x = 0;

                            for (int l = 0; l < nomesEquipamento.Length; l++)
                            {


                                if (excluir == posicaoEquipamento)
                                {
                                    Console.WriteLine("Este equipamento está vinculado a um chamado, ele não pode ser excluido!");
                                    break;
                                }
                                else
                                {
                                    if (l == excluir)
                                    {
                                        nomesEquipamento[l] = null;
                                        precoEquipamento[l] = -1;
                                        serieEquipamentos[l] = null;
                                        fabricanteEquipamento[l] = null;
                                        dataFabricaEquipamento[l] = null;
                                        x = x + 1;
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write(" \n Equipamento excluido com sucesso ☺ ");
                                        Console.ResetColor();
                                    }
                                }






                            }




                        }







                    }
                }


                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Gestão de Equipamentos ");
                    Console.WriteLine();

                    Console.WriteLine("Digite [1] para inserir novo chamado ");
                    Console.WriteLine("Digite [2] para visualizar chamado ");
                    Console.WriteLine("Digite [3] para editar chamado ");
                    Console.WriteLine("Digite [4] para excluir um chamado ");

                    Console.WriteLine("Digite [S] para voltar para o MENU ");

                    string opcaosubmenu = Console.ReadLine();
                    if (opcaosubmenu == "s")
                        continue;

                    if (opcaosubmenu == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Gestão de Equipamentos");
                        Console.WriteLine();

                        Console.Write("Digite o título do chamado (" + c + "): ");
                        nomeChamado[c] = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Digite a posição do equipamento equivalente ao chamado (" + c + "): ");
                        posicaoEquipChamado[c] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        Console.Write("Digite a descrição do equipamento equivalente ao chamado (" + c + "): ");
                        descricao[c] = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Digite a data de abertura do chamado (" + c + "): ");
                        dataChamado[c] = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Registre o numero de ID do solicitant do chamado (" + c + "): ");
                        nID[c] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" \n Chamado cadastrado com sucesso ☺ ");
                        Console.ResetColor();

                        DateTime dataAberturaChamado = Convert.ToDateTime(dataChamado[c]);

                        TimeSpan diasAberto = DateTime.Today - dataAberturaChamado;

                        dias = diasAberto.TotalDays;


                    }

                    else if (opcaosubmenu == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Gestão de Equipamentos");
                        Console.WriteLine();

                        Console.WriteLine("▓▓▓▓Visualizando Equipamentos▓▓▓");
                        Console.WriteLine("====================================");
                        for (int posicao = 0; posicao < 1000; posicao++)
                        {
                            if (nomeChamado[posicao] != null)
                            {
                                Console.WriteLine("Nome\t\t" + nomeChamado[posicao]);
                                Console.WriteLine("Posição Equipamento Chamado\t\t" + posicaoEquipChamado[posicao]);
                                Console.WriteLine("Descrição\t\t" + descricao[posicao]);
                                Console.WriteLine("Data do chamado\t\t" + dataChamado[posicao]);
                                Console.WriteLine("Nº de ID\t\t" + nID[posicao]);
                                Console.WriteLine();
                                Console.WriteLine("_______________________");
                                Console.WriteLine();
                            }
                        }




                    }
                    else if (opcaosubmenu == "3")
                    {
                        Console.Write("Digite a posição do chamado que você deseja alterar: ");
                        int alterarChamado = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Edite o título do chamado " + alterarChamado + ": ");
                        nomeChamado[alterarChamado] = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Edite a posição do equipamento equivalente ao chamado " + alterarChamado + ": ");
                        posicaoEquipChamado[alterarChamado] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        Console.Write("Edite a descrição do equipamento equivalente ao chamado " + alterarChamado + ": ");
                        descricao[alterarChamado] = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Edite a data de abertura do chamado " + alterarChamado + ": ");
                        dataChamado[alterarChamado] = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Registre o numero de ID do solicitant do chamado " + alterarChamado + ": ");
                        nID[alterarChamado] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" \n Chamado editado com sucesso ☺ ");
                        Console.ResetColor();

                        DateTime dataAberturaChamado = Convert.ToDateTime(dataChamado[alterarChamado]);

                        TimeSpan diasAberto = DateTime.Today - dataAberturaChamado;

                        dias = diasAberto.TotalDays;






                    }
                    else if (opcaosubmenu == "4")
                    {
                        Console.Write("Digite a posição do chamado que deseja excluir: ");
                        int excluir = Convert.ToInt32(Console.ReadLine());

                        for (int l = 0; l < nomeChamado.Length; l++)
                        {
                            if (l == excluir)
                            {
                                nomeChamado[l] = null;
                                posicaoEquipChamado[l] = -1;
                                descricao[l] = null;
                                dataChamado[l] = null;
                                nID[l] = -1;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" \n Chamado excluido com sucesso ☺ ");
                                Console.ResetColor();
                            }
                        }






                    }




                }
                Console.ReadLine();

            }
        }


    }
}
