using Comex.Models;

namespace Comex.Menus; 
internal class MenuOrdernarPorTitulo:Menu {

    public override void Executar(List<Produto> produtos) {

        base.Executar(produtos);
        ExibirTitulo("Produtos Ordenados por Titulo");

        var produtosOrdenadosPorNome =
            from produto in produtos
            orderby produto.Nome ascending
            select produto;

        foreach (var produto in produtosOrdenadosPorNome) {
            Console.WriteLine($"# {produto.Nome}  \n- Preço:  R$ {produto.PrecoUnitario} \n");
        }

        FinalizarOperacao();
    }
}
