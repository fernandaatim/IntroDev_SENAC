using Inseto;

namespace Principal
{
    public class Principal
    {
        static void Main(string[] args)
        {
            Abelha abelha = new Abelha();
            Formiga formiga = new Formiga();
            abelha.picar();
            abelha.voar();
            abelha.polinizar();
            Console.WriteLine("---------------");
            formiga.picar();
            formiga.juntarComida();
            formiga.descansar();
            Console.ReadKey();
        }
    }
}