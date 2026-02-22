using ControleDeContas.Queries;
using ControleDeContas.Services;

var service = new ContaService();

Console.WriteLine("  Carregando contas...");
await service.CarregarContas();

Console.WriteLine("\n  Listagem inicial:");
service.ListarContas();

Console.WriteLine("\n  Total de dinheiro:");
Filtros.TotalDeDinhero(service.Contas);

Console.WriteLine("\n  Conta com maior saldo:");
Filtros.ContaComMaiorSaldo(service.Contas);


Console.WriteLine("\n  Buscando Por Nome:");
Filtros.BuscarPorNome(service.Contas, "julia");

Console.WriteLine("\n  Ordenando por nome:");
Filtros.OrdenarContasPorNome(service.Contas);

Console.WriteLine("\n  Ordenando por saldo:");
Filtros.OrdenarContasPorGrana(service.Contas);

Console.WriteLine("\n  Agrupando por região:");
Filtros.AgruparPorRegiao(service.Contas);

Console.WriteLine("\n  Exemplo de nova conta (comentado):");

// Exemplo de como adicionar:
// var novaConta = new Conta("Novo Usuario", 1000, "1234", "Sul");
// service.AdicionarContas(novaConta);

Console.WriteLine("\n Salvando alterações...");
await service.SalvarContas();

Console.WriteLine("\nPipeline finalizada!");

