using System.ComponentModel.Design;

namespace GestorProduto
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool menu = true;
            var manage = new ProdutoManager();
            
            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Remover Produto");
                Console.WriteLine("3 - Editar Produto");
                Console.WriteLine("4 - Listar Produtos");
                Console.WriteLine("5 - Sair");
                Console.Write("\nDigite a sua opção: ");

                 int entrada = manage.LerInt();
                 Menu opcao = (Menu)entrada;
                

                switch (opcao)
                {
                    case Menu.Cadastrar:
                        manage.CadastrarProduto();
                        break;

                    case Menu.Remover:
                        manage.RemoverProduto();
                        break;

                    case Menu.Editar:
                        manage.EditarProduto();
                        break;

                    case Menu.Listar:
                        manage.ListarProdutos();
                        break;

                    case Menu.Sair:
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
