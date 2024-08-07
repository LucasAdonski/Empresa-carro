public class Industria
{
    public string Nome { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }

    public List<LinhaProducao> LinhaProducoes = new List<LinhaProducao>();

    public string ExibirInformacoes()
    {
        return "Nome: " + this.Nome +
            "\nLocalizacao: " + this.Localizacao +
            "\nAno da fundacao: " + this.AnoFundacao;
    }

    public void AdicionarLinhaProducao(LinhaProducao lp)
    {
        this.LinhaProducoes.Add(lp);
    }
}
