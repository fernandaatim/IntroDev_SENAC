namespace Inseto
{
    public class Inseto
    {
        public int qtdPatas;
        public Boolean asas;
        public void picar(){
            Console.WriteLine("Um inseto pica");
        }
    }

    public class Abelha : Inseto{
        public new int qtdPatas = 6;
        public new Boolean asas = true;
        
        public void voar(){
            Console.WriteLine("Uma abelha voa");
        }
        public void polinizar(){
            Console.WriteLine("Uma abelha poliniza");
        }
    }

    public class Formiga : Inseto{
        public new int qtdPatas = 6; 
        public new Boolean asas = false;
        public int qtdEspinhos;
        public string especie = "";
        
        public void juntarComida(){
            Console.WriteLine("As formigas juntam comida");
        }
        public void descansar(){
            Console.WriteLine("Descansar né, que o homem não é de ferro!");
        }
    }
}