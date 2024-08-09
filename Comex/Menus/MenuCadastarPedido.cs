using Comex.Models;

namespace Comex.Menus; 
internal class MenuCadastrarPedido:Menu {
    
    public MenuCadastrarPedido(List<Pedido> pedidos, List<Cliente> clientes) {
        Pedidos = pedidos;
        Clientes = clientes;
    }

    public List<Cliente> Clientes { get; set; }
    public List<Pedido> Pedidos { get; set; }
    public override void Executar(List<Produto> produtos) {
        Console.Clear();

        Random random = new Random();


        ExibirTitulo("Cadastrar Pedido");
        Console.Write("Digite o Nome do Cliente:");
        string nomeCliente = Console.ReadLine()!;
       
        Cliente clienteDoPedido = null;
        foreach (var cliente in Clientes) {
            if (cliente.Nome.Equals(nomeCliente)) {
                clienteDoPedido = cliente;
            }
        }

        if (clienteDoPedido != null) {
            int numeroDoPedido = random.Next(1000, 5000);
            Pedido pedido = new Pedido(clienteDoPedido) { Numero = numeroDoPedido, Data = DateTime.Now};
            Pedidos.Add(pedido);
            Console.WriteLine($"\nPedido Criado com o número {numeroDoPedido}!\n");
        }
        else {
            Console.WriteLine($"\nCliente não cadastrado!\n");
        }
        

        FinalizarOperacao();
    }
}
