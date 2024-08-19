
namespace BiblioSharp.Models; 
internal class Livro {
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public DateTime DataPublicacao { get; set; }
    public bool EstaEmprestado { get; set; }

    public Livro() {
        EstaEmprestado = false;
    }
    public Livro(string titulo) {
        Titulo = titulo;
    }

    public bool Emprestar() {
        if (!EstaEmprestado) {
            EstaEmprestado = true;
            return true;
        }else{
            Console.WriteLine($"\n>> Livro {Titulo} - {Autor} não está disponivel!");
            return false;
        }
        
    }

    public bool Devolver() {
        if (EstaEmprestado) {
            EstaEmprestado = false;
            return true;
        }
        else {
            Console.WriteLine($"\n>> Livro {Titulo} - {Autor} não foi emprestado!");
            return false;
        }
    }

    public void ExibirInformações() {
        Console.WriteLine($"");
        Console.WriteLine($"Titulo do Livro: {Titulo}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Data de Publicação: {DataPublicacao}");
        if (EstaEmprestado) Console.WriteLine("Status: Emprestado!");
        else Console.WriteLine("Status: Disponível para Empréstimo!");
    }

}
