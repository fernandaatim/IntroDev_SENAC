namespace Program
{
    public class Tarefa
    {
        public String nome { get; set; }
        public String data { get; set; }
        public String hora { get; set; }
        public String descricao { get; set; }

        public Boolean status { get; set; }

        public Tarefa(string nome, string data, string hora, string descricao, Boolean status)
        {
            this.nome = nome;
            this.data = data;
            this.hora = hora;
            this.descricao = descricao;
            this.status = status;

            RepoTarefa.tarefas.Add(this);
        }

        public static List<Tarefa> ListarTarefas()
        {
            return RepoTarefa.tarefas;
        }

        public static void AlterarTarefa(int indice, string nome, string data, string hora, string descricao, Boolean status)
        {
            Tarefa tarefa = RepoTarefa.tarefas[indice];

            tarefa.nome = nome;
            tarefa.data = data;
            tarefa.hora = hora;
            tarefa.descricao = descricao;
            tarefa.status = status;

            RepoTarefa.tarefas[indice] = tarefa;
        }

        public static void AlterarStatus(Boolean status, int resposta)
        {
            if (resposta == 1)
            {
                status = true;
            }
            else
            {
                status = false;
            }
        }

        public static void DeletarTarefa(int indice)
        {
            RepoTarefa.tarefas.RemoveAt(indice);
        }
    }
}