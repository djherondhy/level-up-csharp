using Comex.Menus;
using Comex.Models;

internal class MenuListarCliente : Menu {
    public List<Cliente> Clientes;

    public MenuListarCliente(List<Cliente> clientes) {
        Clientes = clientes;
    }

    public override void Executar(List<Produto> produtos) {
        base.Executar(produtos);

        ExibirTitulo("Listar Clientes");

        foreach (var cliente in Clientes) {
            Console.WriteLine(cliente.Identificacao);
        }

        FinalizarOperacao();
    }
 }