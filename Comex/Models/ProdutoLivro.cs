namespace Comex.Models;
internal class ProdutoLivro : Produto, IIdentificacao{
    public ProdutoLivro(string nome, double preco) : base(nome, preco) {
    }

    string Isbn { get; set; }
    int TotalPáginas { get; set; }

    public string Identificacao => $"Nome: {Nome} | ISBN: {Isbn}";
}
