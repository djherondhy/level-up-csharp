using BiblioSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Menus; 
internal class MenuEmprestarLivro : Menu {

    public override void Executar(Biblioteca biblioteca) {
        base.Executar(biblioteca);
        Console.WriteLine(">> Emprestar Livro\n");

        Console.Write("Digite o CPF do Usuário: ");
        string cpf = Console.ReadLine()!;
        Usuario usuario = null;
        Livro livro = null;
        foreach (var user in biblioteca.Usuarios) {
            if (user.CPF.Equals(cpf)) {
                usuario = user;
            }
        }

        if (usuario != null) {
            Console.Write("Digite o ISBN do livro que deseja emprestar: ");
            string isbn = Console.ReadLine()!;

            foreach (var book in biblioteca.Livros) {
                if (book.ISBN.Equals(isbn)) {
                    livro = book;
                }
            }

            if (livro != null) { 
                usuario.EmprestarLivro(livro);
            }
            else {
                Console.WriteLine("\n>> Este livro não existe na biblioteca!");
            }


        }
        else {
            Console.WriteLine("\n>> Este usuário não está registrado!");
        }

        FinalizarOperacao();
    }

}
