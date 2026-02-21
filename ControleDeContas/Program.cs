

using ControleDeContas.Models;
using ControleDeContas.Services;

var service = new ContaService();
await service.CarregarContas();
//Conta conta1 = new Conta("julia", 1034, "1295");
//Conta conta2 = new Conta("Josu", 134, "adn");


//service.AdicionarContas(conta1);
//service.AdicionarContas(conta2);

service.ListarContas();
service.RemoverContas(Guid.Parse("c7dec0b6-3bc5-4832-9e23-5c4b5dd0a039"), "adn");
//service.ListarContas();
//await service.SalvarContas();
Console.WriteLine("-------------------------------");
