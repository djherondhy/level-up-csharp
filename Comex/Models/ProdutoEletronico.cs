namespace Comex.Models;
internal class ProdutoEletronico : Produto  {
    public ProdutoEletronico(string nome, double preco) : base(nome, preco) {
        
    }

    int Voltagem { get; set; }
    int Potencia { get; set; }

    
}
