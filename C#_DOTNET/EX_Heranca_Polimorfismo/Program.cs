namespace Programa {
    public class Program {
        static void Main() {
            // int[] nome = new int[2];
            Pessoa[] pessoas = new Pessoa[2];

            for(int i = 0; i <= 1; i++){
                pessoas[i] = new Pessoa();

                Console.WriteLine("Digite seu nome: ");
                pessoas[i].Nome = Console.ReadLine();
                Console.WriteLine("Digite seu Login: ");
                pessoas[i].Login = Console.ReadLine();
                Console.WriteLine("Digite seu Senha: ");
                pessoas[i].Senha = Console.ReadLine();
                Console.WriteLine("Digite a sua idade: ");
                pessoas[i].Idade = Convert.ToInt32(Console.ReadLine());
            }

            // pessoas[0].Apresentar();
            // pessoas[1].Apresentar();
            pessoas[1].Logar();
        }
    }
}