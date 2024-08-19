using BiblioSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Menus; 
internal class MenuRegistrarLivro : Menu {
    public override void Executar(Biblioteca biblioteca) {
        base.Executar(biblioteca);
        Console.WriteLine(">> Registrar Livro");
        Console.Write("\nDigite o ISBN do livro: ");
        string isbn = Console.ReadLine()!;
        bool livroExiste = false;
        foreach (var book in biblioteca.Livros) {
            if (book.ISBN.Equals(isbn)) {
                livroExiste = true; 
            }
        }

        if (livroExiste) { Console.WriteLine("\n>> Livro já existente!"); }
        else {
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine()!;
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine()!;
            Console.Write("Insira a data de publicação (formato: dd/MM/yyyy HH:mm):");
            string data = Console.ReadLine()!;
            DateTime dataConvertida = DateTime.Parse(data);
            biblioteca.AdicionarLivro(new Livro(titulo) { ISBN = isbn, Autor = autor,DataPublicacao = dataConvertida });

        }

        FinalizarOperacao();
    }
}
