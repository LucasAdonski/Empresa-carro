public class Maquina
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public List<Produto> Produtos = new List<Produto>();

    public string ExibirInfo()
    {
        return "Identificador: " + this.Id +
            "\nMarca: " + this.Marca +
            "\nModelo: " + this.Modelo;
    }

    public void IniciarProducao(Produto p)
    {
        this.Produtos.Add(p);
    }
}
