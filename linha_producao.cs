public class LinhaProducao
{
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public int Capacidade { get; set; }

    public List<Maquina> Maquinas = new List<Maquina>();

    public string ExibirDetalhes()
    {
        return "Numero da linha: " + this.Numero +
            "\nTipo da producao: " + this.Tipo +
            "\nCapacidade: " + this.Capacidade + "p/h";
    }

    public void AdicionarMaquina(Maquina M)
    {
        this.Maquinas.Add(M);
    }
}
