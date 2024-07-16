string mensagemBoasVindas = "Sejam Bem Vindos ao Comex";
List<Produto> produtos = new List<Produto>();

void ExibirMenu() {                                      

    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");

    Console.WriteLine("\n" + mensagemBoasVindas);
    Console.WriteLine("\n1 - Criar Produto.");
    Console.WriteLine("2 - Listar Produtos.");
    Console.WriteLine("-1 - Sair.");
    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) {
        case 1: CadastrarProduto(); break;
        case 2: ListarProdutos(); break;
        case -1: Console.WriteLine("Obrigado por Utilizar");  break;
        default: Console.WriteLine("Opção Inválida"); Thread.Sleep(1000); Console.Clear(); ExibirMenu(); break;
    }
}

void CadastrarProduto() {
    Console.Clear();
    ExibirTitulo("Cadastrar Produtos");
  
    Console.Write("Insira o nome do produto: ");
    string nomeProduto = Console.ReadLine()!;

    Console.Write("Digite o Preço Unitário: ");
    string preco = Console.ReadLine()!;
    double precoConvertido;
    double.TryParse(preco, out precoConvertido);

    Console.Write("Digite a Quantidade em Estoque: ");
    string quantidade = Console.ReadLine()!;
    int quantidadeConvertida = int.Parse(quantidade);


    Produto produto = new Produto(nomeProduto, precoConvertido) {
        Quantidade = quantidadeConvertida
    };

    produtos.Add(produto);

    Console.WriteLine($"\nO Produto {nomeProduto} Cadastrado com Sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();

}

void ListarProdutos() {
    Console.Clear();
    ExibirTitulo("Lista de Produtos");

    foreach (var produto in produtos) {
        Console.WriteLine(produto.Descricao);
    }
    
}


void ExibirTitulo(string titulo) {
    int tamTitulo = titulo.Length;
    string asteriscos = "" + String.Empty.PadRight(tamTitulo, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
    Console.WriteLine("");
}

ExibirMenu();