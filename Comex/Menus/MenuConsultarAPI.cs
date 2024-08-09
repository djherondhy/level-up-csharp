
using Comex.Models;
using System.Text.Json;
namespace Comex.Menus;
internal class MenuConsultarAPI : Menu {

    public async Task Executar() {
        using HttpClient client = new HttpClient();

       Console.Clear();
        ExibirTitulo("Exibindo Produtos");

        try {
            string resposta = await client.GetStringAsync("http://fakestoreapi.com/products");
            var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta);
            foreach (var produto in produtos) {
                Console.WriteLine($"Nome: {produto.Nome}, " +
                    $"Preço {produto.PrecoUnitario} \n");
            }
        }
        catch (Exception ex) {

            Console.WriteLine($"Temos um problema: {ex.Message}");
        }
        finally {
            FinalizarOperacao();
        }
    }
}
