class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Produto(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public static List<Produto> produtos = new List<Produto>();


    public static void CadastrarProduto()
    {
        Console.Write("\nDigite o nome do produto: ");
         string nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("O Nome não pode conter apenas espaços vazios.");
            return;
        }

         int id = produtos.Count + 1;

        Produto produto = new Produto(id, nome);
        produtos.Add(produto);
        Console.WriteLine("\nProduto cadastrado com sucesso!");
    }
    public static void RemoverProduto()
    {
        Console.Write("\nDigite o ID do produto que deseja remover: ");
        int idRemover = int.Parse(Console.ReadLine());

        Produto produtoRemover = produtos.Find(p => p.Id == idRemover);

        if (produtoRemover != null)
        {
            produtos.Remove(produtoRemover);
            Console.WriteLine("\nProduto removido com sucesso!");
        }
        else
        {
            Console.WriteLine("\nProduto não encontrado.");
        }
    }
    public static void EditarProduto()
    {
        Console.Write("\nDigite o ID do produto que deseja editar:");
        int idEditar = int.Parse(Console.ReadLine());

        Produto produtoEditar = produtos.Find(p => p.Id == idEditar);

        if (produtoEditar != null)
        {
            Console.Write("\nDigite o novo nome do produto: ");
            string novoNome = Console.ReadLine();

            produtoEditar.Nome = novoNome;
            Console.WriteLine("\nProduto editado com sucesso!");
        }
        else
        {
            Console.WriteLine("\nProduto não encontrado.");
        }
    }
    public static void ListarProdutos()
    {
        Console.WriteLine("\nLista de Produtos:");
        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"\nNome: {produto.Nome}");
            Console.WriteLine($"ID: {produto.Id}");
        }
    }
}
