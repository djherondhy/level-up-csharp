namespace Comex.Models;
internal class Cliente: IIdentificacao{

    public Cliente(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public string Identificacao => $"Nome: {Nome} | CPF: {CPF}";
}