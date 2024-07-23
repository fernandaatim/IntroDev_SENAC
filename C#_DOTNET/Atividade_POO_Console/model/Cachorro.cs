namespace Projeto{
    public class Cachorro{
        public int ID{get;set;}
        public string? Nome {get;set;}
        public string? Dono{get;set;}
        public int Idade{get;set;}
        public int qtdBrinquedos{get;set;}
        public Boolean dormindo{get;set;}


        public void Brincar(){
            Console.WriteLine($"{Nome} corre pelo quintal!");
            dormindo = false;
        }

        public void Dormir(){
            dormindo = true;
            Console.WriteLine("ZzzzZZZzzzZZZ...");
            Thread.Sleep(1000);
            Console.WriteLine("ZzzzZZZzzzZZZ...");
            Thread.Sleep(1000);
            Console.WriteLine("ZzzzZZZzzzZZZ...");
            Thread.Sleep(1000);
        }
    }
}