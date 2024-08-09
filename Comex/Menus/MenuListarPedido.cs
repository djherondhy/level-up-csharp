using Comex.Models;

namespace Comex.Menus; 
internal class MenuListarPedido:Menu {
    
    public MenuListarPedido(List<Pedido> pedidos) {
        Pedidos = pedidos;
        
    }
    public List<Pedido> Pedidos { get; set; }
    public override void Executar(List<Produto> produtos) {
        Console.Clear();

        Random random = new Random();

        ExibirTitulo("Listar Pedidos");
        foreach(var pedidos in Pedidos) {
            pedidos.detalharPedido();
        }

        FinalizarOperacao();
    }
}
