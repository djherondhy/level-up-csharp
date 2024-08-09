using Comex.Models;

namespace Comex.Menus; 
internal class MenuAdicionarItem:Menu {
    
    public MenuAdicionarItem(List<Pedido> pedidos) {
        Pedidos = pedidos;
      
    }

  
    public List<Pedido> Pedidos { get; set; }
    public override void Executar(List<Produto> produtos) {
        Console.Clear();
        ExibirTitulo("Detalhar Pedido");
        Console.Write("Digite o número do pedido:");
        string numeroPedido = Console.ReadLine()!;
        int numeroPedidoConvertido = int.Parse(numeroPedido);

        Pedido pedidoAtual = null;
        
      

        foreach (var pedido in Pedidos) {
            if (pedido.Numero == numeroPedidoConvertido) {
                pedidoAtual = pedido;
            }
        }

        if (pedidoAtual != null) {
            Console.Write("Digite o nome do produto que deseja adicionar:");
            string nomeDoProduto = Console.ReadLine()!;
           
            Produto produtoDoItem = null;
            foreach(var produto in produtos) {
                if (produto.Nome.Equals(nomeDoProduto)) {
                    
                    produtoDoItem = produto;
                }
            }
            if (produtoDoItem != null) {
                Console.Write("Digite a quantidade do produto: ");
                string quantidade =  Console.ReadLine()!;
                int quantidadeConvertida = int.Parse(quantidade);
                ItemDePedido item = new ItemDePedido() { Produto = produtoDoItem, PrecoUnitario = produtoDoItem.PrecoUnitario, Quantidade = quantidadeConvertida  };
                pedidoAtual.AdicionarItem(item);
                Console.WriteLine("\nItem Adicionado com Sucesso!\n");
            }
            else {
                Console.WriteLine("\nProduto não cadastrado na lista de produtos!\n");
            }

            
        }
        else {
            Console.WriteLine("\nPedido não encontrado na lista de pedidos!\n");
        }
        FinalizarOperacao();
    }
}
