namespace Programa{
    public class PessoaCont{
        public static void CriarPessoa(string nome,int idade){
            new Pessoa(nome,idade);
        }

        public static List<Pessoa> ListarPessoa(){
            // if(pessoas.Count == 0) {
            //     Console.WriteLine("Nenhum pessoa cadastrada no sistema");
            // } else {
            //     foreach (Pessoa pessoa in pessoas) {
            //         Console.WriteLine($"{pessoa.Nome}\n{pessoa.Idade}");
            //         Console.WriteLine("---------------\n");

            //     }
            // }
                return Pessoa.ListarPessoa();
        }

        public static void DeletarPessoa(int indice){
            List<Pessoa> pessoas = ListarPessoa();
             if(indice >= 0 && indice < pessoas.Count()) {
                Pessoa.DeletarPessoa(indice);
                Console.WriteLine("Pessoa deletada com sucesso;");
            } else {
                Console.WriteLine("Indice inválido");
            }
        }

        public static void AlterarPessoa(int indice, string nome, int idade){
            List<Pessoa> pessoas = ListarPessoa();
            if(indice >= 0 && indice < pessoas.Count){
                Pessoa.AlterarPessoa(indice, nome, idade);
                Console.WriteLine("Pessoa Alterada com sucesso;");
            } else {
                Console.WriteLine("Indice inválido");
            }
        }
    }
}