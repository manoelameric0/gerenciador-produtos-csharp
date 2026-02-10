using System.ComponentModel.Design;

namespace GestorProduto
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool executando = true;
            var gestor = new ProdutoManager();
            
            Console.WriteLine("\n===Bem Vindo ao Sistema Gestor de Produtos===");

            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Remover Produto");
                Console.WriteLine("3 - Editar Produto");
                Console.WriteLine("4 - Listar Produtos");
                Console.WriteLine("5 - Sair");
                Console.Write("\nDigite a sua opção: ");

                 int entrada = gestor.LerInt();

                 //cast de int para enum
                 Menu opcao = (Menu)entrada;
                

                switch (opcao)
                {
                    case Menu.Cadastrar:
                        gestor.CadastrarProduto();
                        break;

                    case Menu.Remover:
                        gestor.RemoverProduto();
                        break;

                    case Menu.Editar:
                        gestor.EditarProduto();
                        break;

                    case Menu.Listar:
                        gestor.ListarProdutos();
                        break;

                    case Menu.Sair:
                        executando = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (executando);
            
        }
    }
}
