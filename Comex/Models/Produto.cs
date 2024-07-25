namespace Comex.Models;
internal class Produto{

    public Produto(string nome, double preco) {
        Nome = nome;
        PrecoUnitario = preco;
    }
    public string Nome { get; }
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
    public string Descricao => $"Produto: {Nome} \nPreço Unitário: R$ {PrecoUnitario} \n{Quantidade} unidades em Estoque \n";

    
}