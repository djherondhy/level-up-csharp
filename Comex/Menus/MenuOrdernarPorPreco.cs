

using Comex.Models;

namespace Comex.Menus; 
internal class MenuOrdenarPorPreco:Menu {

    public override void Executar(List<Produto> produtos) {
        base.Executar(produtos);
        
        base.Executar(produtos);
        ExibirTitulo("Produtos Ordenados por Preço");

        var produtosOrdenadosPorPreco = produtos.OrderBy(p => p.PrecoUnitario);

        foreach (var produto in produtosOrdenadosPorPreco) {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: R$ {produto.PrecoUnitario}");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
        Console.ReadKey();
        Console.Clear();
    }

}
