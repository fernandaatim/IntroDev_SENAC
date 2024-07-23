namespace Program
{
    public class ConTarefa
    {
        public static void CriarTarefa(string nome, string data, string hora, string descricao, Boolean status)
        {
            status = false;
            new Tarefa(nome, data, hora, descricao, status);
        }

        public static List<Tarefa> ListarTarefas()
        {
            return Tarefa.ListarTarefas();
        }

        public static void DeletarTarefa(int indice)
        {
            List<Tarefa> tarefas = ListarTarefas();
            if (indice >= 0 && indice < tarefas.Count)
            {
                Tarefa.DeletarTarefa(indice);
                Console.WriteLine("Tarefa excluída com êxito!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }

        public static void Status(Boolean status)
        {
            if (status == false)
            {
                Console.WriteLine("Status: Pendente\n");
            }
            else
            {
                Console.WriteLine("Status: Concluída\n");
            }
        }

        public static void AlterarTarefa(int indice, string nome, string data, string hora, string descricao, Boolean status)
        {
            List<Tarefa> tarefas = ListarTarefas();
            if (indice >= 0 && indice < tarefas.Count())
            {
                Tarefa.AlterarTarefa(indice, nome, data, hora, descricao, status);
                Console.WriteLine("Tarefa atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }
    }
}
