Industria ltda = new Industria();
ltda.Nome = "Naves Cic";
ltda.Localizacao = "Caiua - CIC";
ltda.AnoFundacao = 2000;

Console.WriteLine(ltda.ExibirInformacoes());

LinhaProducao linha1 = new LinhaProducao();
linha1.Numero = 1;
linha1.Tipo = "Carros";
linha1.Capacidade = 01;

Maquina Maquina = new Maquina();
Maquina.Id = 1;
Maquina.Marca = "Peugeot";
Maquina.Modelo = "Maquina 01";

linha1.AdicionarMaquina(Maquina);

Produto Produto = new Produto();
Produto.Nome = "Peugeot 308";
Produto.Codigo = 1;
Produto.Preco = 36.000;

Produto.AtualizarPreco(36.500);
Maquina.IniciarProducao(Produto);

Console.WriteLine(Produto.ExibirDetalhes());

Maquina = new Maquina();
Maquina.Id = 2;
Maquina.Marca = "Nissan";
Maquina.Modelo = "Maquina 02";

linha1.AdicionarMaquina(Maquina);

Produto = new Produto();
Produto.Nome = "Versa";
Produto.Codigo = 2;
Produto.Preco = 50.000;

Maquina.IniciarProducao(Produto);
Console.WriteLine(Produto.ExibirDetalhes());

foreach (var M in linha1.Maquinas){
    Console.WriteLine(M.ExibirInfo());
 }

ltda.AdicionarLinhaProducao(linha1);

linha1 = new LinhaProducao();
linha1.Numero = 2;
linha1.Tipo = "Motos";
linha1.Capacidade = 01;

ltda.AdicionarLinhaProducao(linha1);

Maquina = new Maquina();
Maquina.Id = 3;
Maquina.Marca = "Honda";
Maquina.Modelo = "Maquina 03";

linha1.AdicionarMaquina(Maquina);

Produto = new Produto();
Produto.Nome = "Start 160";
Produto.Codigo = 3;
Produto.Preco = 15.000;

Maquina.IniciarProducao(Produto);
Console.WriteLine(Produto.ExibirDetalhes());

Maquina = new Maquina();
Maquina.Id = 4;
Maquina.Marca = "Yamaha";
Maquina.Modelo = "Maquina 04";

linha1.AdicionarMaquina(Maquina);

Produto = new Produto();
Produto.Nome = "Fazer";
Produto.Codigo = 4;
Produto.Preco = 22.000;

Maquina.IniciarProducao(Produto);
Console.WriteLine(Produto.ExibirDetalhes());

foreach (var M in linha1.Maquinas){
    Console.WriteLine(M.ExibirInfo());
}

foreach (var L in ltda.LinhaProducoes){
    Console.WriteLine(L.ExibirDetalhes());
}
