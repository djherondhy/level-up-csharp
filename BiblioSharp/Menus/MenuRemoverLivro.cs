using BiblioSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Menus; 
internal class MenuRemoverLivro : Menu {
    public override void Executar(Biblioteca biblioteca) {
        base.Executar(biblioteca);
        Console.WriteLine(">> Remover Livro");
        Console.Write("\nDigite o ISBN do livro que deseja remover: ");
        string isbn = Console.ReadLine()!;
        Livro livroParaRemover = null;
        foreach (var book in biblioteca.Livros) {
            if (book.ISBN.Equals(isbn)) {
                livroParaRemover = book; 
            }
        }
        if (livroParaRemover!=null) {
            biblioteca.RemoverLivro(livroParaRemover);
        }
        else {
            Console.WriteLine("\n>> Este livro não existe na biblioteca!");
        }


        FinalizarOperacao();
    }
}
