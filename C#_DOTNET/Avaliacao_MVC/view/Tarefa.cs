namespace Program
{
    public class ViewTarefa
    {
        public static void CriarTarefa()
        {
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a data(xx/yy/zz):");
            string data = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a hora(xx:yy):");
            string hora = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a descrição:");
            string descricao = Console.ReadLine() ?? "";
            Boolean status = false;

            ConTarefa.CriarTarefa(nome, data, hora, descricao, status);
        }

        public static void ListarTarefas()
        {
            Console.WriteLine("== TAREFAS ==");
            List<Tarefa> tarefas = ConTarefa.ListarTarefas();
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa encontrada");
            }
            else
            {
                foreach (Tarefa tarefa in tarefas)
                {
                    Console.WriteLine($"Nome: {tarefa.nome}\nData: {tarefa.data}\nHora: {tarefa.hora}\nDescrição:{tarefa.descricao}");
                    ConTarefa.Status(tarefa.status);
                }
            }
        }

        public static void AlterarTarefa()
        {
            Console.WriteLine("Informe o indice da pessoa para alterar:");
            int indice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a data(xx/yy/zz):");
            string data = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a hora(xx:yy):");
            string hora = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a descrição:");
            string descricao = Console.ReadLine() ?? "";
            Console.WriteLine("Tarefa conclúida? ([1]Sim [2]Não)");
            int resposta = Convert.ToInt32(Console.ReadLine());
            Boolean status;
            if (resposta == 1)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            ConTarefa.AlterarTarefa(indice, nome, data, hora, descricao, status);
        }
        public static void DeletarTarefa()
        {
            Console.WriteLine("Digite o índice:");
            int indice = Convert.ToInt32(Console.ReadLine());
            ConTarefa.DeletarTarefa(indice);
        }

        public static void Pressiona()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}