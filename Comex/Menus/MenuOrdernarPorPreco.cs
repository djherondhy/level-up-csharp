

using Comex.Models;

namespace Comex.Menus; 
internal class MenuOrdernarPorPreco:Menu {

    public override void Executar(List<Produto> produtos) {
        
        
        base.Executar(produtos);
        ExibirTitulo("Produtos Ordenados por Preço");

        var produtosOrdenadosPorPreco =
            from produto in produtos
            orderby produto.PrecoUnitario ascending
            select produto;

        foreach (var produto in produtosOrdenadosPorPreco) {
            Console.WriteLine($"# {produto.Nome}  \n- Preço:  R$ {produto.PrecoUnitario} \n");
        }

        FinalizarOperacao();

    }

}
