using Comex.Models;

namespace Comex.Menus; 
internal class MenuDetalharPedido:Menu {
    
    public MenuDetalharPedido(List<Pedido> pedidos) {
        Pedidos = pedidos;
      
    }

  
    public List<Pedido> Pedidos { get; set; }
    public override void Executar(List<Produto> produtos) {
        Console.Clear();
        ExibirTitulo("Detalhar Pedido");
        Console.WriteLine("Digite o número do pedido:");
        string numeroPedido = Console.ReadLine()!;
        int numeroPedidoConvertido = int.Parse(numeroPedido);
        Pedido pedidoAtual = null;
        foreach(var pedidos in Pedidos) {
            if(pedidos.Numero == numeroPedidoConvertido) {
                pedidoAtual = pedidos;
            }
        }
        if(pedidoAtual != null) {
            pedidoAtual.detalharItemsDoPedido();
            Console.WriteLine("");
        }
        else {
            Console.WriteLine("\nPedido não registrado na lista de pedidos!\n");
        }
        FinalizarOperacao();
    }
}
