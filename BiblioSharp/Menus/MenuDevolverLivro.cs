using BiblioSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Menus; 
internal class MenuDevolverLivro : Menu {

    public override void Executar(Biblioteca biblioteca) {
        base.Executar(biblioteca);
        Console.WriteLine(">> Devolver Livro\n");

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
            if (usuario.LivrosEmprestados.Count > 0) {
                usuario.ExibirLivrosEmprestados();
                Console.Write("Digite o ISBN do livro que deseja devolver: ");
                string isbn = Console.ReadLine()!;
                foreach (var book in usuario.LivrosEmprestados) {
                    if (book.ISBN.Equals(isbn)) {
                        livro = book;
                    }
                }

                if (livro != null) {
                    usuario.DevolverLivro(livro);
                }
                else {
                    Console.WriteLine("\n>> Este livro não foi emprestado!");
                }

            }
            else {
                Console.WriteLine("\n>> Nenhum livro para devolver!");
            }
           
        }
        else {
            Console.WriteLine("\n>> Este usuário não está registrado!");
        }

        FinalizarOperacao();
    }

}
