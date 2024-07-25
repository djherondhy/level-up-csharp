using Comex.Menus;
using Comex.Models;
using System.Net;

internal class Program {
    private static void Main(string[] args) {
        string mensagemBoasVindas = "Sejam Bem Vindos ao Comex";
        List<Produto> produtos = new List<Produto>();
        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuCadastrarProduto());
        opcoes.Add(2, new MenuListarProdutos());
        opcoes.Add(3, new MenuOrdernarPorTitulo());
        opcoes.Add(4, new MenuOrdernarPorPreco());


        void ExibirMenu() {

            Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");

            Console.WriteLine("\n" + mensagemBoasVindas);
            Console.WriteLine("\n1 - Criar Produto.");
            Console.WriteLine("2 - Listar Produtos.");
            Console.WriteLine("3 - Ordernar Produtos por Titulo.");
            Console.WriteLine("4 - Ordernar Produtos por Preço.");
            Console.WriteLine("-1 - Sair.");
            Console.Write("\nDigite a opção desejada: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if(opcaoEscolhidaNumerica > 0) {
                Menu menu = opcoes[opcaoEscolhidaNumerica];
                menu.Executar(produtos);
                ExibirMenu();
            }
            else {
                Console.WriteLine("Tchau!");
            }
           
        }

        ExibirMenu();
    }
}