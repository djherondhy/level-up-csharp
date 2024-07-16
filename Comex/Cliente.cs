/*
Crie a classe Cliente com seus respectivos atributos:

Nome (Texto)
CPF (Texto)
E-mail (Texto)
Profissão (Texto).
Telefone (Texto)
Endereço (Endereco)
 */
class Cliente {

    public Cliente(string nome) {
        Nome = nome;
    }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }

}