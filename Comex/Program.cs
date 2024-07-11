string mensagemBoasVindas = "Sejam Bem Vindos ao Comex";

Dictionary<String, double> produtos = new Dictionary<String, double>();

void ExibirMenu() {
    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");

    Console.WriteLine("\n"+mensagemBoasVindas);
    Console.WriteLine("\n1 - Criar Produto.");
    Console.WriteLine("2 - Listar Produtos.");
    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) {
        case 1: CadastrarProduto(); break;
        case 2: ListarProdutos(); break;
        
    }
}

void CadastrarProduto() {
    Console.Clear();
    ExibirTitulo("Cadastrar Produtos");
    Console.Write("Insira o nome do produto: ");
    string nomeProduto = Console.ReadLine()!;
    Console.Write("Digite o Preço: ");
    string preco = Console.ReadLine()!;
    double precoConvertido;
    double.TryParse(preco, out precoConvertido);
    produtos.Add(nomeProduto, precoConvertido);
    Console.WriteLine($"\nO Produto {nomeProduto} Cadastrado com Sucesso!");
    Thread.Sleep(2000);
    Console.Clear() ;
    ExibirMenu();

}

void ListarProdutos() {
    Console.Clear();
    ExibirTitulo("Lista de Produtos");

    foreach (var produto in produtos) {
        Console.WriteLine($"\nNome do Produto: {produto.Key}");
        Console.WriteLine($"Preço: {produto.Value}");
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