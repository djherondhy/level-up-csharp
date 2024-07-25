

using Comex.Models;

namespace Comex.Menus; 
internal class MenuListarProdutos: Menu {

    public override void Executar(List<Produto> produtos) {
        base.Executar(produtos);
        
        ExibirTitulo("Lista de Produtos");

        foreach (var produto in produtos) {
            Console.WriteLine(produto.Descricao);
        }
    }
}
