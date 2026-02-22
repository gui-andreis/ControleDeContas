using ControleDeContas.Utils;

namespace ControleDeContas.Models
{
    internal class Conta(string nome, decimal saldo, string senha, string regiao)
    {
        public string Nome { get; } = TextoUtils.Capitalizar(nome.Trim());
        public decimal Saldo { get; set; } = saldo;
        public string Senha { get; set; } = senha;
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Regiao { get; set; } = TextoUtils.Capitalizar(regiao.Trim());

    }
}
