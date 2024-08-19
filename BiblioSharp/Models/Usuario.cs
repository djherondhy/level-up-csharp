

namespace BiblioSharp.Models;
internal class Usuario {
    public string Nome { get; set; }
    public string CPF { get; set; }

    public List<Livro> LivrosEmprestados = new List<Livro>();

    public List<Livro> Historico = new List<Livro>();

    public Usuario(string nome, string cpf) { Nome = nome; CPF = cpf; }
    public void EmprestarLivro(Livro livro) {
        if (LivrosEmprestados.Count >= 3) {
            Console.WriteLine("\n>> Você não pode emprestar mais de 3 livros simultaneamente!");
        }
        else {
            if (livro.Emprestar()) {
                LivrosEmprestados.Add(livro);
                Historico.Add(livro);
                Console.WriteLine($"\n>> Livro {livro.Titulo} - {livro.Autor} Emprestado!");
            }
            
        }

    }

    public void DevolverLivro(Livro livro) {
        if (livro.Devolver()) {
            LivrosEmprestados.Remove(livro);
            Console.WriteLine($"\n>> Livro  {livro.Titulo} - {livro.Autor} Devolvido!");
        }
        
    }

    public void ExibirLivrosEmprestados() {
        Console.WriteLine("\n>> Livros Emprestados");
        Console.WriteLine($"Usuário: {Nome}\n");

        foreach (var livro in LivrosEmprestados) {
            Console.WriteLine($"{livro.Titulo} - {livro.Autor} | ISBN: {livro.ISBN}");
        }
        Console.WriteLine("");

    }

    public void ExibirHistorico() {
        Console.WriteLine($"\nUsuário: {Nome}");

        if (Historico.Count > 0) {
            foreach (var livro in Historico) {

                Console.WriteLine($"{livro.Titulo} - {livro.Autor} | ISBN: {livro.ISBN}");

            }
            Console.WriteLine("");
        }
        else {
            Console.WriteLine("\n>> Nenhum livro foi emprestado!");
        }
      
    }

}
