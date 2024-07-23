using Model;
using MySqlConnector;

namespace Repository {
    public class RepositoryTarefa {
        private static MySqlConnection conexao;
        static readonly List<Tarefa> tarefas = new List<Tarefa>();

        public static List<Tarefa> RepositoryTarefas(){
            return tarefas;
        }
       //
        public static Tarefa GetTarefa(int indice){
            if(indice < 0 || indice >= tarefas.Count){
                return null;
            }else{
                return tarefas[indice];
            }
        }
        //
        public static void InitConexao(){
            string query = "server=localhost;database=avaliacaorenan; user id=root; password=''";
            conexao = new MySqlConnection(query);

            try{
                conexao.Open();
            }catch{
                Console.WriteLine("Erro ao conectar ao banco de dados");
            }
        }
        //
        public static void CloseConexao(){
            conexao.Close();
        }
        //
        public static List<Tarefa> Sincronizar(){
            InitConexao();
            string query = "SELECT * FROM tarefa";
            MySqlCommand command = new MySqlCommand(query,conexao);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
                int id = Convert.ToInt32(reader["id"].ToString());
                Tarefa tarefa = new Tarefa
                {
                    Id = id,
                    Nome = reader["nome"].ToString(),
                    Data = reader["data"].ToString(),
                    Hora = reader["hora"].ToString(),
                    Descricao = reader["descricao"].ToString()
                };
                tarefas.Add(tarefa);
            }
            CloseConexao();
            return tarefas;
        }
        //CRIAR UMA TAREFA
        public static void CriarTarefa(Tarefa tarefa){
            InitConexao();
            string query = "INSERT INTO tarefa (nome, data, hora, descricao) VALUES (@Nome,@Data,@Hora,@Descricao)";
            MySqlCommand command = new MySqlCommand(query,conexao);

            try{
                if(tarefa.Nome == null || tarefa.Data == null || tarefa.Hora == null || tarefa.Descricao == null){
                    MessageBox.Show("Todos dados devem estar preenchidos!");
                }else{
                    command.Parameters.AddWithValue("@Nome", tarefa.Nome);
                    command.Parameters.AddWithValue("@Data", tarefa.Data);
                    command.Parameters.AddWithValue("@Hora", tarefa.Hora);
                    command.Parameters.AddWithValue("@Descricao", tarefa.Descricao);

                    int rowsAffected = command.ExecuteNonQuery();
                    tarefa.Id = Convert.ToInt32(command.LastInsertedId);

                    if(rowsAffected > 0){
                        MessageBox.Show("Tarefa criada com sucesso!");
                        tarefas.Add(tarefa);
                    }else{
                        MessageBox.Show("Erro ao criar tarefa!");
                    }
                }
            }catch{
                MessageBox.Show("Erro!");
            }
            CloseConexao();
        }
        //EXCLUIR UMA TAREFA
        public static void ExcluirTarefa(int indice){
            InitConexao();
            string query = "DELETE FROM tarefa WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(query,conexao);
            command.Parameters.AddWithValue("@Id",tarefas[indice].Id);
            int rowsAffected = command.ExecuteNonQuery();

            if(rowsAffected > 0){
                tarefas.RemoveAt(indice);
                MessageBox.Show("Tarefa excluída com sucesso!");
            }else{
                MessageBox.Show("Erro ao excluir tarefa!");
            }
            CloseConexao();
        }
        //ALTERAR UMA TAREFA
        public static void AlterarTarefa(int indice, Tarefa tarefa){
            InitConexao();
            string query = "UPDATE tarefa SET nome = @Nome, data = @Data, hora = @Hora, descricao = @Descricao WHERE id=@Id";
            MySqlCommand command = new MySqlCommand(query,conexao);
            try{
                if(tarefas != null){
                    command.Parameters.AddWithValue("@Id", tarefas[indice].Id);
                    command.Parameters.AddWithValue("@Nome", tarefa.Nome);
                    command.Parameters.AddWithValue("@Data", tarefa.Data);
                    command.Parameters.AddWithValue("@Hora", tarefa.Hora);
                    command.Parameters.AddWithValue("@Descricao", tarefa.Descricao);
                    int rowsAffected = command.ExecuteNonQuery();

                    if(rowsAffected > 0){
                        tarefas[indice] = tarefa;
                        MessageBox.Show("Tarefa alterada com sucesso!");
                    }else{
                        MessageBox.Show("Erro ao alterar tarefa!");
                    }
                }else{
                    MessageBox.Show("Tarefa não encontrada!");
                }
            }catch{
                MessageBox.Show("Erro ao alterar!");
            }
            CloseConexao();
        }
    }
}