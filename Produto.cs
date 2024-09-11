public class Produto
{
    public string Nome;
    public int Quantidade;
    public double Preco;

    public Produto()
    {
        Nome = "";
        Quantidade = 0;
        Preco = 0.0;
    }

    public void DefinirDados(string nome, int quantidade, double preco)
    {
        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            Quantidade += quantidade;
        }
        else
        {
            Console.WriteLine("Quantidade a adicionar deve ser maior que zero.");
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            if (quantidade <= Quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade a ser removida é maior do que a disponível em estoque.");
            }
        }
        else
        {
            Console.WriteLine("Quantidade a remover deve ser maior que zero.");
        }
    }

    public double CalcularValorEstoque()
    {
        return Quantidade * Preco;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Produto: {Nome}");
        Console.WriteLine($"Quantidade em estoque: {Quantidade}");
        Console.WriteLine($"Preço unitário: {Preco:C}");
        Console.WriteLine($"Valor total em estoque: {CalcularValorEstoque():C}");
    }
}
