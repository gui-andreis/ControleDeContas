using ControleDeContas.Models;
using System.Text.Json;



namespace ControleDeContas.Services
{
    internal class ContaService
    {
        private List<Conta> _contas = new List<Conta>();

        public void AdicionarContas(Conta conta)
        {
            _contas.Add(conta);
            Console.WriteLine($"conta de {conta.Nome} adicionada com sucesso");
        }

        public IReadOnlyList<Conta> Contas => _contas;
        public void ListarContas()
        {
            if (_contas.Count > 0)
            {              
                foreach (Conta conta in _contas)
                    Console.WriteLine($"{conta.Nome,-20} | Saldo: {conta.Saldo,15:C} | ID: {conta.ID}");
            }
            else
            {
                Console.WriteLine("não há contas listadas");
            }
        }

        public void RemoverContas(Guid ID, string senha)
        {
           int removidas = _contas.RemoveAll(contas => contas.ID == ID && contas.Senha == senha);
            if (removidas > 0)
            {
                Console.WriteLine($"Conta de {ID} removida com sucesso");
            }
            else
            {
                Console.WriteLine("Não foi possível encotrar uma conta com esse Títular e Senha");
            }
        }
        
        public async Task SalvarContas()
        {
            var path_file = @"C:\\Users\\Pichau\\source\\repos\\ControleDeContas\\ControleDeContas\\Data\\contas.json";
            using FileStream fs = File.Create(path_file);
            await JsonSerializer.SerializeAsync(fs, _contas);
            Console.WriteLine("Salvo Com Sucesso");
        }

        public async Task CarregarContas()
        {
            var path_file = "C:\\Users\\Pichau\\source\\repos\\ControleDeContas\\ControleDeContas\\Data\\contas.json";
            if (File.Exists(path_file))
            {
                try
                {
                    using FileStream fs = File.OpenRead(path_file);
                    _contas = await JsonSerializer.DeserializeAsync<List<Conta>>(fs) ?? new List<Conta>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar contas: {ex.Message}");
                }
            
            }
        }
    }
}

