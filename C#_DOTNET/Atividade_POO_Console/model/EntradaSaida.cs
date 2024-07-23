namespace Projeto{
    public class EntradaSaida{
        public static void exibirCachorros(String canil) {
        Console.WriteLine(canil);
    }
        public static void pressioneTecla(){
            Console.WriteLine("Aperte qualquer tecla para prosseguir...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}