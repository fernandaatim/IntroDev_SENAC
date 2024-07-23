namespace Projeto
{
    public class Canil
    {
        List<Cachorro> canil = new List<Cachorro>();

        public void adicionarCachorro(Cachorro c)
        {
            canil.Add(c);
        }

        public void removerCachorro(Cachorro c)
        {
            canil.Remove(c);
        }

        public String listaCachorros()
        {
            String cachorro = "Cachorros cadastrados:\n";
            int posicao;
            foreach (Cachorro c in canil)
            { 
                posicao = canil.IndexOf(c);
                cachorro += "\n-------------------------\n";
                cachorro += $"ID:{posicao}\n";
                cachorro += $"Nome: {c.Nome}\n";
                cachorro += $"Nome do dono: {c.Dono}\n";
                cachorro += $"Idade: {c.Idade}\n";
                cachorro += $"Quantidade de brinquedos: {c.qtdBrinquedos}\n";
                cachorro += $"Dormindo: {c.dormindo}\n";
                cachorro += "\n-------------------------\n";
            }
            return cachorro;
        }
        public Cachorro pesquisarCachorroID(int ID){
            foreach(Cachorro c in canil){
                if(ID == canil.IndexOf(c)){
                    return c;
                }
            }
            return null;
        }
    }
}