using Model;

namespace Controller{
    public class ControllerTarefa{
        public static void Sincronizar(){
            Tarefa.Sincronizar();
        }
        //LISTAR
        public static List<Tarefa> ListarTarefas(){
            return Tarefa.ListarTarefas();
        }
        //CRIAR
        public static void CriarTarefa(string nome, string data, string hora,string descricao){
            new Tarefa(nome,data,hora,descricao);
        }
        //ALTERAR
        public static void AlterarTarefa(int indice,string nome, string data, string hora,string descricao){
            Tarefa.AlterarTarefa(indice,nome,data,hora,descricao);
        }
        //EXCLUIR
        public static void ExcluirTarefa(int indice){
            List<Tarefa> tarefas = ListarTarefas();

            if(indice >= 0 && indice < tarefas.Count){
                Tarefa.ExcluirTarefa(indice);
            }else{
                MessageBox.Show("Indice invalido");
            }
        }
    }
}