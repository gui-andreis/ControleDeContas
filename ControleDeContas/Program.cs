

using ControleDeContas.Models;
using ControleDeContas.Queries;
using ControleDeContas.Services;

var service = new ContaService();
await service.CarregarContas();



//service.ListarContas();

//Filtros.TotalDeDinhero(service.Contas);
//Filtros.OrdenarContasPorNome(service.Contas);
//Console.WriteLine(new string ('-' , 20));
//Filtros.ContaComMaiorSaldo(service.Contas);
//Console.WriteLine(new string('-', 20));
//Filtros.BuscarPorNome(service.Contas, "Julia");
//Console.WriteLine(new string('-', 20));

//Console.WriteLine(new string('-', 20));
//service.ListarContas();


Filtros.AgruparPorRegiao(service.Contas);
await service.SalvarContas();

