using System;
using System.Collections.Generic;
using MySqlConnector;
using Model;

namespace Repo
{
    public class RepoUser
    {
        private static MySqlConnection conexao;
        static List<User> users = new List<User>();

        public static List<User> ListUsers()
        {
            return users;
        }

        public static void InitConexao()
        {
            string info = "server=localhost;database=bibliotechdb;user id=root;password=''";
            conexao = new MySqlConnection(info);
            try
            {
                conexao.Open();
            }
            catch
            {
                // Handle exception
                Console.WriteLine("Connection failed");
            }
        }

        public static void CloseConexao()
        {
            conexao.Close();
        }

        public static List<User> Sincronizar()
        {
            InitConexao();
            string querySync = "SELECT * FROM usuarios";
            MySqlCommand command = new MySqlCommand(querySync, conexao);
            MySqlDataReader readerSync = command.ExecuteReader();

            while (readerSync.Read())
            {
                // Assume User object has a constructor to initialize from a DataReader
                User user = new User
                {
                    Id = Convert.ToInt32(readerSync["id_usuario"].ToString()),
                    Usuario = readerSync["nome"].ToString() ?? "",
                    Data_nascimento = readerSync["data_nascimento"].ToString() ?? "",
                    Cpf = readerSync["cpf"].ToString() ?? ""
                };

                users.Add(user);
            }

            CloseConexao();
            return users;
        }

        public static void Criar(User user)
        {
            InitConexao();
            string insert = "INSERT INTO usuarios (nome, data_nascimento, cpf) VALUES (@Nome, @Data_nascimento, @Cpf)";
            MySqlCommand command = new MySqlCommand(insert, conexao);
            try
            {
                if (user.Usuario == null || user.Data_nascimento == null || user.Cpf == null)
                {
                    Console.WriteLine("Deu ruim, favor preencher a pessoa");
                }
                else
                {
                    command.Parameters.AddWithValue("@Nome", user.Usuario);
                    command.Parameters.AddWithValue("@Data_nascimento", user.Data_nascimento);
                    command.Parameters.AddWithValue("@Cpf", user.Cpf);

                    int rowsAffected = command.ExecuteNonQuery();
                    user.Id = Convert.ToInt32(command.LastInsertedId);

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Usuario cadastrado com sucesso");
                        users.Add(user);
                    }
                    else
                    {
                        Console.WriteLine("Deu ruim, não deu pra adicionar");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Deu ruim: " + e.Message);
            }

            CloseConexao();
        }

        public static void Update(int indice, string usuario, string data_nascimento, string cpf)
        {
            InitConexao();
            Console.WriteLine("iniciando");
            string query = "UPDATE usuarios SET nome = @Nome, data_nascimento = @Data_nascimento, cpf = @Cpf WHERE id_usuario = @Id";
            MySqlCommand command = new MySqlCommand(query, conexao);
            User user = users[indice];
            try
            {
                if (usuario != null || data_nascimento != null || cpf != null)
                {
                    command.Parameters.AddWithValue("@Id", user.Id);
                    command.Parameters.AddWithValue("@Nome", usuario);
                    command.Parameters.AddWithValue("@Cpf", cpf);
                    command.Parameters.AddWithValue("@Data_nascimento", data_nascimento);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        user.Usuario = usuario;
                        user.Data_nascimento = data_nascimento;
                        user.Cpf = cpf;
                    }
                    else
                    {
                        Console.WriteLine(rowsAffected.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro durante a execução do comando: " + ex.Message);
            }
            CloseConexao();
        }

        public static void Delete(int index)
        {
            InitConexao();
            string delete = "DELETE FROM usuarios WHERE id_usuario = @Id";
            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@Id", users[index].Id);
            // executar
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                users.RemoveAt(index);
                Console.WriteLine("Usuário deletado com sucesso.");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
            CloseConexao();
        }
    }
}
