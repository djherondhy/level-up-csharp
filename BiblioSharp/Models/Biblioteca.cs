using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Models;
internal class Biblioteca {

    public List<Usuario> Usuarios { get; set;}
    public List<Livro> Livros  { get; set; }

    public void AdicionarLivro(Livro livro) {
        Livros.Add(livro);
        Console.WriteLine("\n>>Livro Adicionado!");
    }

    public void RemoverLivro(Livro livro) {
        if (Livros.Contains(livro)) { Livros.Remove(livro); Console.WriteLine("\n>>Livro Removido!"); }
        else {
            Console.WriteLine("\n>>Este livro não existe na biblioteca!");
        }
    }

    public void AdicionarUsuario(Usuario usuario) { 
        Usuarios.Add(usuario);
        Console.WriteLine("\n>>Usuário Adicionado!");
    }

    public void ExibirLivrosDisponiveis() {
        foreach (var livro in Livros) {
            if (!livro.EstaEmprestado) {
                livro.ExibirInformações();
            }
        }
    }

    public void ExibirListaUsuarios() {
 
        foreach (var user in Usuarios) {
            Console.WriteLine($"Nome: {user.Nome} | CPF: {user.CPF}");
        }
    }


}
