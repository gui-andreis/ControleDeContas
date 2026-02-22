using ControleDeContas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ControleDeContas.Queries
{
    internal class Filtros
    {

        public static void BuscarPorNome(IReadOnlyList<Conta> contas, string nome)
        {
            var contaFiltradas = contas.Where(c => c.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();

            if (contaFiltradas.Count > 0) 
            {
                foreach (var conta in contaFiltradas) 
                    Console.WriteLine($"{conta.Nome,-10} | Saldo: {conta.Saldo,10:C} | Região:{conta.Regiao,-12} |  ID: {conta.ID}"); 
            }
        }

        public static void TotalDeDinhero(IReadOnlyList<Conta> contas)
        {
            decimal total = contas.Sum(c => c.Saldo);
            Console.WriteLine($"O Total de dinheiro de todas as pessoas é de {total} Reais");

        }

        public static void OrdenarContasPorNome(IReadOnlyList<Conta> contas)
        {
            var cOrdenadas = contas.OrderBy(c => c.Nome).ToList();
            foreach (var conta in cOrdenadas)
                Console.WriteLine($"{conta.Nome,-20} | Saldo: {conta.Saldo,15:C} | Região:{conta.Regiao,-12} |  ID: {conta.ID}");
        }

        public static void OrdenarContasPorGrana(IReadOnlyList<Conta> contas)
        {
            var c_ordenadas = contas.OrderByDescending(c => c.Saldo).ToList();
            foreach (var conta in c_ordenadas)
                Console.WriteLine($"{conta.Nome,-20} | Saldo: {conta.Saldo,15:C} | Região:{conta.Regiao,-12} | ID: {conta.ID}");
        }

        public static void ContaComMaiorSaldo(IReadOnlyList<Conta> contas)
        {
            var conta = contas.OrderByDescending(c => c.Saldo).FirstOrDefault();
            if (conta != null)
                Console.WriteLine($"Titular:{conta.Nome,-20},Região:{conta.Regiao},Saldo:{conta.Saldo,15:C},ID:{conta.ID}");
            else
                Console.WriteLine("Nenhuma conta encontrada");
        }

        public static void AgruparPorRegiao(IReadOnlyList<Conta> contas)
        {
            var regioes = contas
                .GroupBy(c => c.Regiao);
            foreach (var regiao in regioes)
            {
                Console.WriteLine($"\n--- {regiao.Key} ---");
                foreach (var conta in regiao)
                {
                    Console.WriteLine($"{conta.Nome,-10} | Saldo: {conta.Saldo,10:C} | Região: {conta.Regiao,-12}  |  ID: {conta.ID}");
                }
            }
        }
    }
}
