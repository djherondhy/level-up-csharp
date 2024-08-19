using BiblioSharp.Models;
using BiblioSharp.Menus;

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarUsuario());
opcoes.Add(2, new MenuRegistrarLivro());
opcoes.Add(3, new MenuRemoverLivro());
opcoes.Add(4, new MenuListarLivros());
opcoes.Add(5, new MenuListarUsuarios());
opcoes.Add(6, new MenuEmprestarLivro());
opcoes.Add(7, new MenuDevolverLivro());
opcoes.Add(8, new MenuHistoricoEmprestimos());

Biblioteca biblioteca = new();
biblioteca.Livros = new List<Livro>(){
   new Livro("O Senhor dos Anéis: A Sociedade do Anel")
                {
                    Autor = "J.R.R. Tolkien",
                    DataPublicacao = new DateTime(1954, 7, 29),
                    ISBN = "978-0544003415"
                },
                new Livro("O Senhor dos Anéis: As Duas Torres")
                {
                    Autor = "J.R.R. Tolkien",
                    DataPublicacao = new DateTime(1954, 11, 11),
                    ISBN = "978-0544003416"
                },
                new Livro("O Senhor dos Anéis: O Retorno do Rei")
                {
                    Autor = "J.R.R. Tolkien",
                    DataPublicacao = new DateTime(1955, 10, 20),
                    ISBN = "978-0544003417"
                },
                new Livro("1984")
                {
                    Autor = "George Orwell",
                    DataPublicacao = new DateTime(1949, 6, 8),
                    ISBN = "978-0451524935"
                },
                new Livro("Brave New World")
                {
                    Autor = "Aldous Huxley",
                    DataPublicacao = new DateTime(1932, 8, 1),
                    ISBN = "978-0060850524"
                },
                new Livro("Fahrenheit 451")
                {
                    Autor = "Ray Bradbury",
                    DataPublicacao = new DateTime(1953, 10, 19),
                    ISBN = "978-1451673319"
                },
                new Livro("Moby Dick")
                {
                    Autor = "Herman Melville",
                    DataPublicacao = new DateTime(1851, 11, 14),
                    ISBN = "978-1503280786"
                },
                new Livro("O Grande Gatsby")
                {
                    Autor = "F. Scott Fitzgerald",
                    DataPublicacao = new DateTime(1925, 4, 10),
                    ISBN = "978-0743273565"
                },
                new Livro("Crime e Castigo")
                {
                    Autor = "Fiódor Dostoiévski",
                    DataPublicacao = new DateTime(1866, 1, 1),
                    ISBN = "978-0486415871"
                },
                new Livro("Guerra e Paz")
                {
                    Autor = "Liev Tolstói",
                    DataPublicacao = new DateTime(1869, 1, 1),
                    ISBN = "978-0199232765"
                }
};

biblioteca.Usuarios = new() {
    new Usuario("Djhérondhy", "052.720.312-29") {
        LivrosEmprestados = new List<Livro>() {
            biblioteca.Livros[0], biblioteca.Livros[1], biblioteca.Livros[2]
        },
        Historico =  new List<Livro>() {
            biblioteca.Livros[0], biblioteca.Livros[1], biblioteca.Livros[2]
        }
    }
};

void ExibirMenu() {
    Console.WriteLine("Seja Bem Vindo ao BiblioSharp!\n");

    Console.WriteLine("\n>> Menu de Opções:");
    Console.WriteLine("\n1 -> Registrar Usuário");
    Console.WriteLine("2 -> Registrar Livro");
    Console.WriteLine("3 -> Remover Livro");
    Console.WriteLine("4 -> Listar Livros Disponíveis");
    Console.WriteLine("5 -> Listar Usuários");
    Console.WriteLine("6 -> Emprestrar Livro");
    Console.WriteLine("7 -> Devolver Livro");
    Console.WriteLine("8 -> Histórico de Empréstimos");
    Console.WriteLine("-1 -> Sair");
    Console.Write("\n>> Escolha uma opção: ");

    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    if (opcaoNumerica > 0 && opcaoNumerica <= 8) {
        Menu menu = opcoes[opcaoNumerica];
        menu.Executar(biblioteca);
        ExibirMenu();
    }

}

ExibirMenu();
