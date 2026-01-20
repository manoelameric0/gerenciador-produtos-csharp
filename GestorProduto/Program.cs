using System.ComponentModel.Design;

namespace GestorProduto
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool menu = true;
            
            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Remover Produto");
                Console.WriteLine("3 - Editar Produto");
                Console.WriteLine("4 - Listar Produtos");
                Console.WriteLine("5 - Sair");
                Console.Write("\nDigite a sua opção: ");

                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.Write("Opção inválida. Pressione qualquer tecla para continuar. ");
                    Console.ReadKey();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Produto.CadastrarProduto();
                        break;

                    case 2:
                        Produto.RemoverProduto();
                        break;

                    case 3:
                        Produto.EditarProduto();
                        break;

                    case 4:
                        Produto.ListarProdutos();
                        break;

                    case 5:
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (menu);
            
        }
    }
}
