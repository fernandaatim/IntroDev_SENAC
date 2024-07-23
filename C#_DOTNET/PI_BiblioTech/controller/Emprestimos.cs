using System.Security.Cryptography.X509Certificates;
using Model;
namespace Controller;
public class ControllerEmprestimo
{
    public static void testDB()
    {
        Emprestimo.TestDB();
    }
    public static List<Emprestimo> ListarEmprestimos()
    {
        return Emprestimo.ListarEmprestimo();
    }
    public static void Sincronizar()
    {
        Emprestimo.Sincronizar();
        User.Sincronizar();
        Livro.Sincronizar();
    }
    public static List<User> ListarUser()
    {
        return User.ListarUser();
    }
    public static List<Livro> ListarBook()
    {
        return Livro.ListarLivros();
    }

    public static void Create(string data_emprestimo, string data_prazo, string data_devolucao, string horario, int id_usuario, int id_livro)
    {
        new Emprestimo(data_emprestimo, data_prazo, data_devolucao, horario, id_usuario, id_livro);
    }
    public static void Update(int indece ,string data_emprestimo, string data_prazo, string data_devolucao, string horario)
    {
        Emprestimo.Update(indece,data_emprestimo, data_prazo, data_devolucao, horario);
    }
    public static void Delete(int indece)
    {
        Emprestimo.Delete(indece);
    }
    public static string ObterNomeUsuario(int id)
    {
        // Supondo que você tenha uma lista de usuários ou um método para obter o usuário pelo id
        Emprestimo usuario = ListarEmprestimos().FirstOrDefault(u => u.Id == id);
        return usuario != null ? usuario.Usuario : "Usuário não encontrado";
    }

}