using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models; 
internal class Pedido {

    public int Numero { get; set; }
    public Cliente Cliente { get; set; }
    public List<ItemDePedido> Items = new ();
    public DateTime Data { get; set; }
    public double Total { get; set; }

    public Pedido(Cliente cliente) {
        Cliente = cliente;
    }

    public void AdicionarItem(ItemDePedido item) {
     Items.Add(item);
    }

    public void detalharPedido() {
        Console.WriteLine($"-------------------------------------------------");
        Console.WriteLine($"Pedido #{Numero}");
        Console.WriteLine($"Cliente: {Cliente.Nome}");
        Console.WriteLine($"Data: {Data}");
        Console.WriteLine($"Total: R$ {Total}");
        Console.WriteLine($"-------------------------------------------------");
    }

}
