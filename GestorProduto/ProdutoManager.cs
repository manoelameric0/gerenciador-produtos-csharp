using System;
using System.Net.Security;

namespace GestorProduto;

public enum Menu {Cadastrar = 1, Remover = 2, Editar = 3, Listar = 4, Sair = 5}

public class ProdutoManager
{
    public  List<Produto> produtos = new List<Produto>();

    

    public void CadastrarProduto()
    {
        Console.Write("\nDigite o nome do produto: ");
         string nome = LerString();

        Console.Clear();
        produtos.Add(new Produto(Guid.NewGuid(), nome));
        Console.WriteLine("\nProduto cadastrado com sucesso!");
    }

    public void RemoverProduto()
    {
        Console.Write("\nDigite o ID do produto que deseja remover: ");
        Guid idRemover = LerID();

        Produto produtoRemover = produtos.Find(p => p.Id == idRemover);

        if (produtoRemover != null)
        {
            Console.Clear();
            produtos.Remove(produtoRemover);
            Console.WriteLine("\nProduto removido com sucesso!");
        }
        else
        {
            Console.WriteLine("\nProduto não encontrado.");
        }
    }

     public void EditarProduto()
    {
        Console.Write("\nDigite o ID do produto que deseja editar:");
        Guid idEditar = LerID();

        Produto produtoEditar = produtos.Find(p => p.Id == idEditar);

        if (produtoEditar != null)
        {
            Console.Write("\nDigite o novo nome do produto: ");
            string novoNome = LerString();

            produtoEditar.SetName(novoNome);
            Console.WriteLine("\nProduto editado com sucesso!");
        }
        else
        {
            Console.WriteLine("\nProduto não encontrado.");
        }
    }

     public void ListarProdutos()
    {
        Console.WriteLine("\nLista de Produtos:");
        if (produtos.Count == 0)
        {
            System.Console.WriteLine("\nNenhum Produto Cadastrado!");
        }
        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"\nNome: {produto.Nome}");
            Console.WriteLine($"ID: {produto.Id}");
            
        }
    }

    //Validações

    public string LerString()
    {
        string entrada = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(entrada) || string.IsNullOrEmpty(entrada) || entrada.Any(char.IsDigit))
        {
            System.Console.WriteLine("Nome Inválido!");
            System.Console.Write("Nome: ");
            entrada = Console.ReadLine();
        }

        return entrada;
    }

    public Guid LerID()
    {
        Guid entrada;
        
        while (!Guid.TryParse(Console.ReadLine(), out entrada))
        {
            System.Console.WriteLine("Número inválido");
        }

        
        return entrada;
    }

    public int LerInt()
    {
        int entrada;
        while(!int.TryParse(Console.ReadLine(), out entrada))
        {
            System.Console.WriteLine("Caractere inválido");
        }
        return entrada;
    }
}
