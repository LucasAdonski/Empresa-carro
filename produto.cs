public class Produto
{
    public string Nome { get; set; }
    public int Codigo { get; set; }
    public double Preco { get; set; }

    public string ExibirDetalhes()
    {
        return "Nome: " + this.Nome +
            "\nCodigo: " + this.Codigo +
            "\npreco: " + this.Preco;
    }

    public void AtualizarPreco(double novoPreco)
    {
        this.Preco = novoPreco;
    }
}
