using System.Linq;
namespace Projeto
{
    public class Principal
    {
        static void Main()
        {
            Canil canil = new();
            int opc;
            int opcInteracoes;
            int indice;
            String nomeCachorro;
            Cachorro c;
            Console.Clear();
            do
            {
                Console.WriteLine("\n\n[1]Adicionar um cachorro");
                Console.WriteLine("[2]Interações");
                Console.WriteLine("[3]Listar cachorros");
                Console.WriteLine("[4]Alterar cachorro");
                Console.WriteLine("[5]Remover cachorro");
                Console.WriteLine("[6]Sair");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        c = new Cachorro();
                        Console.WriteLine("Cadastro de Animais");
                        Console.WriteLine("Nome: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Nome do dono: ");
                        c.Dono = Console.ReadLine();
                        Console.WriteLine("Idade: ");
                        c.Idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Quantidade de brinquedos: ");
                        c.qtdBrinquedos = Convert.ToInt32(Console.ReadLine());
                        c.dormindo = false;
                        
                        canil.adicionarCachorro(c);
                        Console.Clear();
                        break;

                    case 2:
                        if (canil != null)
                        {
                            Console.WriteLine("Digite o ID:");
                            indice = Convert.ToInt32(Console.ReadLine());

                            c = canil.pesquisarCachorroID(indice);

                            if (c == null)
                            {
                                Console.WriteLine("Cachorro não encontrado");
                                EntradaSaida.pressioneTecla();
                            }
                            else
                            {
                                do
                                {
                                    Console.WriteLine("[1]Brincar");
                                    Console.WriteLine("[2]Dormir");
                                    Console.WriteLine("[3]Voltar");
                                    opcInteracoes = Convert.ToInt32(Console.ReadLine());
                                    switch (opcInteracoes)
                                    {
                                        case 1:
                                            c.Brincar();
                                            break;

                                        case 2:
                                            c.Dormir();
                                            break;

                                        case 3:
                                            Console.Clear();
                                            Console.WriteLine("Saindo...");
                                            Thread.Sleep(500);
                                            Console.Clear();
                                            break;

                                        default:
                                            Console.WriteLine("Opção inválida!!");
                                            EntradaSaida.pressioneTecla();
                                            break;
                                    }
                                }
                                while (opcInteracoes != 3);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há cachorros cadastrados");
                            EntradaSaida.pressioneTecla();
                        }
                        break;
                    case 3:
                        if (canil != null){
                            EntradaSaida.exibirCachorros(canil.listaCachorros());
                        } else{
                            Console.WriteLine("Não há cachorros cadastrados");
                            EntradaSaida.pressioneTecla();
                        }
                        break;
                    case 4:
                        if (canil != null)
                        {
                            EntradaSaida.exibirCachorros(canil.listaCachorros());
                            EntradaSaida.pressioneTecla();
                            string novoNome;

                            Console.WriteLine("Digite o ID:");
                            indice = Convert.ToInt32(Console.ReadLine());

                            c = canil.pesquisarCachorroID(indice);

                            if (c == null)
                            {
                                Console.WriteLine("Cachorro não encontrado");
                                EntradaSaida.pressioneTecla();
                            }
                            else
                            {
                                Console.WriteLine($"Novo nome para {c.Nome}: ");
                                novoNome = Console.ReadLine() ?? "";
                                c.Nome = novoNome;
                                Console.WriteLine($"Nome alterado para {c.Nome} com sucesso!!");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Não há cachorros cadastrados");
                            EntradaSaida.pressioneTecla();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Digite o ID:");
                        indice = Convert.ToInt32(Console.ReadLine());
                        c = canil.pesquisarCachorroID(indice);

                        if (c == null)
                        {
                            Console.WriteLine("Cachorro não encontrado");
                            EntradaSaida.pressioneTecla();
                        }
                        else
                        {
                            canil.removerCachorro(c);
                            Console.WriteLine("Cachorro excluído com sucesso!");
                            EntradaSaida.pressioneTecla();
                        }
                        break;
                    case 6:
                        Console.Clear();
                        EntradaSaida.exibirCachorros("\nSaindo...");
                        Thread.Sleep(500);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        EntradaSaida.pressioneTecla();
                        break;
                }
            } while (opc != 6);
        }
    }
}