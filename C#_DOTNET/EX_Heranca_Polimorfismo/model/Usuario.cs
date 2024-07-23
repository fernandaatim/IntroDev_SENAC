namespace Programa {
    public class Usuario {
        public string Login { get; set; }
        public string Senha { get; set; }

        public virtual void Logar() {
            Console.WriteLine("Você irá fazer login");
        }
    }
}