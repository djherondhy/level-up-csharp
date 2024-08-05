namespace Comex.Models;
internal class ProdutoEletronico : Produto  {
    public ProdutoEletronico(string nome, double preco) : base(nome) {
        
    }

    int Voltagem { get; set; }
    int Potencia { get; set; }

    
}
