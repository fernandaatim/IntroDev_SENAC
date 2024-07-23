namespace Program{
    public class Program{
        public static void Main(string[] args){
                int op = 0;
                do{
                Console.Clear();
                Console.WriteLine("=== LISTA DE TAREFAS ===\n\n"+
                "[1] Criar tarefa\n[2] Alterar tarefa\n[3] Listar tarefas\n"+
                "[4] Deletar tarefa\n[5] Sair\nEscolha uma opção: "
                );
                op = Convert.ToInt32(Console.ReadLine());
            
                switch(op){
                    case 1: {
                        ViewTarefa.CriarTarefa();
                    }break;

                    case 2: {
                        ViewTarefa.AlterarTarefa();
                    }break;

                    case 3: {
                        Console.Clear();
                        ViewTarefa.ListarTarefas();
                        ViewTarefa.Pressiona();
                    }break;
                        
                    case 4: {
                        ViewTarefa.DeletarTarefa();
                    }break;
                        
                    case 5: {
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                    }break;

                    default:{
                        Console.WriteLine("Opção inválida");
                    }break;
                }

            }while(op!=5);
            
        }
    }
}