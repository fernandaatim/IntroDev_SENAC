using System.Collections;
using System.Diagnostics;
using cont;
using model;
using repo;

namespace view;
public class FuncionarioView
{
    public static void TelaInicial()
    {
        int op = 0;

        do
        {
            Console.WriteLine("--Tela de funcionário--");
            Console.WriteLine("O que você deseja verificar?");
            Console.WriteLine("1- Criar Funcionário");
            Console.WriteLine("2- Listar Funcionários");
            Console.WriteLine("3- Editar Funcionário");
            Console.WriteLine("4- Deletar Funcionário");
            Console.WriteLine("5- Sair");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    CriarFuncionario();
                    break;
                case 2:
                    ListarFuncionarios();
                    break;
                case 3:
                    AlterarFuncionarios();
                    break;
                case 4:
                    DeletarFuncionarios();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        } while (op != 5);
    }
    public static void CriarFuncionario()
    {
        Console.WriteLine("-----Criar Fucnionario-----");
        Console.WriteLine("Digite o nome do Funcionário: ");
        string nome = Console.ReadLine() ?? "";
        Console.WriteLine("Informe a funcao do Funcionario: ");
        string funcao = Console.ReadLine() ?? "";
        Console.WriteLine("ADM? ");
        bool adm =  Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Informe o email do Funcionario: ");
        string email = Console.ReadLine() ?? "";
        Console.WriteLine("Informe a senha do Funcionario: ");
        string senha = Console.ReadLine() ?? "";
        FuncionarioCont.CriarFuncionarios(nome, funcao, adm, email, senha );
    }
    public static void ListarFuncionarios()
    {
        List<Funcionario> funcionarios = FuncionarioCont.ListarFuncionarios();
        foreach (Funcionario funcionario in funcionarios)
            Console.WriteLine($"ID: {funcionario.IdFuncionario}; Nome: {funcionario.Nome}; Funcao: {funcionario.Funcao}");
        {

        }
    }
    public static void AlterarFuncionarios()
    {
        Console.WriteLine("-----Alterar Funcionario-----");
        Console.WriteLine("Informe o Indice do funcionario para alterar: ");
        int idFuncionario = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o nome do Funcionário: ");
        string nome = Console.ReadLine() ?? "";
        Console.WriteLine("Informe a funcao do Funcionario: ");
        string funcao = Console.ReadLine() ?? "";
        Console.WriteLine("Informe o email do Funcionario: ");
        string email = Console.ReadLine() ?? "";
        Console.WriteLine("Informe a senha do Funcionario: ");
        string senha = Console.ReadLine() ?? "";
        Funcionario.AlterarFuncionarios(idFuncionario, nome, funcao, email, senha);
    }
    public static void DeletarFuncionarios()
    {
        Console.WriteLine("-----Deletar Funcionario-----");
        Console.WriteLine("Informe o Indice do funcionario para deletar: ");
        int idFuncionario = Convert.ToInt32(Console.ReadLine());
        FuncionarioCont.DeletarFuncionarios(idFuncionario);
        Console.WriteLine("Funcionario Deletado!");

    }

}