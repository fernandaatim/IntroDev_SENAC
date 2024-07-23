using Repository;

namespace Model{
    public class Tarefa{
        public int Id{get;set;}
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Descricao { get; set; }

        public Tarefa(){}

        //ADD
        public Tarefa(string nome, string data, string hora, string descricao){
            Nome = nome;
            Data = data;
            Hora = hora;
            Descricao = descricao;

            RepositoryTarefa.CriarTarefa(this);
        }
        //LISTA
        public static List<Tarefa>ListarTarefas(){
            return RepositoryTarefa.RepositoryTarefas();
        }
        //SINCRONIZAR
        public static void Sincronizar(){
            RepositoryTarefa.Sincronizar();
        }
        //EXCLUIR
        public static void ExcluirTarefa(int indice){
            RepositoryTarefa.ExcluirTarefa(indice);
        }
        //ALTERAR
        public static void AlterarTarefa(int indice, string nome, string data, string hora, string descricao){
            Tarefa tarefa = RepositoryTarefa.GetTarefa(indice);
            if(tarefa != null){
                tarefa.Nome = nome;
                tarefa.Data = data;
                tarefa.Hora = hora;
                tarefa.Descricao = descricao;
                RepositoryTarefa.AlterarTarefa(indice,tarefa);
            }else{
                MessageBox.Show("Tarefa não encontrada");
            }
        }


    }
}