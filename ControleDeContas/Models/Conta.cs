using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ControleDeContas.Models
{
    internal class Conta(string nome, decimal saldo, string senha)
    {
        public string Nome { get; } = nome;
        public decimal Saldo { get; set; } = saldo;

        public string Senha { get; set; } = senha;

        public Guid ID { get; set; } = Guid.NewGuid();
    }
}
