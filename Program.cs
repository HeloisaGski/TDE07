Produto produto = new Produto();
bool sair = false;

while (!sair)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Definir informações do produto");
    Console.WriteLine("2. Adicionar ao estoque");
    Console.WriteLine("3. Remover do estoque");
    Console.WriteLine("4. Exibir detalhes do produto");
    Console.WriteLine("5. Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            int quantidade = LerQuantidade("Informe a quantidade inicial: ");
            double preco = LerPreco("Informe o preço unitário: ");

            produto.DefinirDados(nome, quantidade, preco);
            break;

        case "2":
            int quantidadeAdicionar = LerQuantidade("Informe a quantidade a ser adicionada: ");
            produto.AdicionarEstoque(quantidadeAdicionar);
            break;

        case "3":
            int quantidadeRemover = LerQuantidade("Informe a quantidade a ser removida: ");
            produto.RemoverEstoque(quantidadeRemover);
            break;

        case "4":
            produto.ExibirDetalhes();
            break;

        case "5":
            sair = true;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    Console.WriteLine();
}

static int LerQuantidade(string mensagem)
{
    int quantidade;
    Console.Write(mensagem);
    while (true)
    {
        string entrada = Console.ReadLine();
        if (int.TryParse(entrada, out quantidade) && quantidade >= 0)
            break;
        Console.Write("Quantidade inválida. Informe uma quantidade positiva: ");
    }
    return quantidade;
}

static double LerPreco(string mensagem)
{
    double preco;
    Console.Write(mensagem);
    while (true)
    {
        string entrada = Console.ReadLine();
        if (double.TryParse(entrada, out preco) && preco >= 0)
            break;
        Console.Write("Preço inválido. Informe um preço positivo: ");
    }
    return preco;
}
