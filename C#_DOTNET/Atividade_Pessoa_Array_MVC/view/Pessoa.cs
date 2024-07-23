using System.Reflection.Metadata.Ecma335;

namespace Programa
{
    public class PessoaView
    {
        public static void CriarPessoa()
        {
            Console.WriteLine(" ----- Criar ----- ");

            Console.WriteLine("Digite o nome da pessoa: ");
            String nome = Console.ReadLine() ?? "";

            Console.WriteLine("Digite a idade da pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            PessoaCont.CriarPessoa(nome, idade);
        }

        public static void ListarPessoa()
        {
            Console.WriteLine(" -----  Listar ----- \n");
            List<Pessoa> pessoas = PessoaCont.ListarPessoa();
            if (pessoas.Count == 0)
            {
                Console.WriteLine("Nenhum pessoa cadastrada no sistema");
            }
            else
            {
                foreach (Pessoa pessoa in pessoas)
                {
                    Console.WriteLine($"{pessoa.Nome}\n{pessoa.Idade}");
                    Console.WriteLine("---------------\n");

                }
            }
        }

        public static void AlterarPessoa()
        {
            Console.WriteLine(" ----- Alterar ----- ");
            Console.WriteLine("Informe o indice da pessoa para alterar:");
            int indice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome da pessoa para alterar:");
            String nome = Console.ReadLine() ?? "";

            Console.WriteLine("Digite a idade da pessoa para alterar:");
            int idade = Convert.ToInt32(Console.ReadLine());

            PessoaCont.AlterarPessoa(indice,nome,idade);
        }
        public static void DeletarPessoa()
        {
            Console.WriteLine(" ----- Deletar ----- ");
            Console.WriteLine("Informe o indice da pessoa para deleta:");
            int indice = Convert.ToInt32(Console.ReadLine());
            PessoaCont.DeletarPessoa(indice);
        }
    }
}