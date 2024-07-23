namespace Programa {
    public class Pessoa {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome,int idade){
            Nome = nome;
            Idade = idade;

            PessoaRep.pessoas.Add(this);
        }

        public static List<Pessoa> ListarPessoa(){
            return PessoaRep.pessoas;
        }

        public void Falar() {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        public static void DeletarPessoa(int indice){
            PessoaRep.pessoas.RemoveAt(indice);
        }

        public static void AlterarPessoa(int indice,string nome,int idade){
            PessoaRep.pessoas[indice].Nome = nome;
            PessoaRep.pessoas[indice].Idade = idade;

            // Pessoa pessoa = PessoaRep.pessoas[indice];
            // pessoa.Nome = nome;
            // pessoa.Idade = idade;
            // PessoaRep.pessoas[indice] = pessoa;
        }
    }
}
