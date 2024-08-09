using Comex.Menus;
using Comex.Models;
using System.Net;
using System.Text.Json;



string mensagemBoasVindas = "Sejam Bem Vindos ao Comex";
List<Produto> produtos = new List<Produto>() {

            new Produto("Arroz 5kg") { Quantidade = 20, PrecoUnitario = 15.50m},
            new Produto("Feijão 1kg") { Quantidade = 50, PrecoUnitario = 6.75m },
            new Produto("Macarrão 500g") { Quantidade = 30, PrecoUnitario = 3.25m },
            new Produto("Óleo de Soja 900ml") { Quantidade = 40, PrecoUnitario = 8.99m },
            new Produto("Açúcar 2kg") { Quantidade = 25, PrecoUnitario = 7.80m },
            new Produto("Café 500g") { Quantidade = 35, PrecoUnitario = 12.00m },
            new Produto("Leite Integral 1L") { Quantidade = 45, PrecoUnitario = 4.50m },
            new Produto("Farinha de Trigo 1kg") { Quantidade = 30, PrecoUnitario = 5.20m },
            new Produto("Biscoito Cream Cracker 200g") { Quantidade = 50, PrecoUnitario = 3.80m },
            new Produto("Sabonete 90g") { Quantidade = 60, PrecoUnitario = 2.25m }

};

List<Cliente> clientes = new() {
   new Cliente("Djhérondhy"){CPF = "000.000.000-01"},
   new Cliente("Eduarda"){CPF = "000.000.000-02"}
};
List<Pedido> pedidos = new() {
    new Pedido(clientes[0]){Numero = 1000, Data = DateTime.Now}
};



Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCadastrarProduto());
opcoes.Add(2, new MenuListarProdutos());
opcoes.Add(3, new MenuOrdernarPorTitulo());
opcoes.Add(4, new MenuOrdernarPorPreco());
opcoes.Add(5, new MenuConsultarAPI());
opcoes.Add(6, new MenuCadastrarCliente(clientes));
opcoes.Add(7, new MenuListarCliente(clientes));
opcoes.Add(8, new MenuCadastrarPedido(pedidos,clientes));
opcoes.Add(9, new MenuListarPedido(pedidos));
opcoes.Add(10, new MenuAdicionarItem(pedidos));
opcoes.Add(11, new MenuDetalharPedido(pedidos));
async Task ExibirMenu() {
    Console.Clear();
    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");

    Console.WriteLine("\n" + mensagemBoasVindas);
    Console.WriteLine("\n1.   Criar Produto.");
    Console.WriteLine("2.   Listar Produtos.");
    Console.WriteLine("3.   Ordernar Produtos por Titulo.");
    Console.WriteLine("4.   Ordernar Produtos por Preço.");
    Console.WriteLine("5.   Consultar Produtos de API Externa.");
    Console.WriteLine("6.   Cadastrar Clientes");
    Console.WriteLine("7.   Listar Clientes");
    Console.WriteLine("8.   Criar Pedido");
    Console.WriteLine("9.   Listar Pedidos");
    Console.WriteLine("10.  Adicionar Item em Pedido");
    Console.WriteLine("11.  Detalhar Pedido");
    Console.WriteLine("\n-1. Sair.");
    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcaoEscolhidaNumerica > 0) {

        if (opcaoEscolhidaNumerica == 5) {
            await new MenuConsultarAPI().Executar();
            await ExibirMenu();
        }
        else {
            Menu menu = opcoes[opcaoEscolhidaNumerica];
            menu.Executar(produtos);
            await ExibirMenu();
        }
       

    }
    else {
        Console.WriteLine("Tchau!");
    }

}

await ExibirMenu();




