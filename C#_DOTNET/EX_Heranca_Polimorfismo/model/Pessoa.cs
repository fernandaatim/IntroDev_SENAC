namespace Programa {
    public class Pessoa : Usuario {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }

        public void Apresentar() {
            Console.WriteLine($"Olá meu nome é {Nome}, eu tenho {Idade} anos.");
        }
        public override void Logar() {
            Console.WriteLine($"{Nome} - Bem vindo ao sistema.");
        }
    }
}