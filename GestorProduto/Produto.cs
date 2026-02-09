public class Produto
{
    public Guid Id;
    public string Nome { get; private set; }

    public Produto(Guid id, string nome)
    {
        Id = id;
        Nome = nome;
    }
   
    public string SetName(string name)
    {
        return Nome = name;
    }
}
