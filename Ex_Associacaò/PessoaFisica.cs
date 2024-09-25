using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Associacaò
{
    internal class PessoaFisica: Pessoa
    {
        public string CPF { get; set; }

        public PessoaFisica(string nome, string telefone, Endereco endereco, int idade, string cPF)
            : base(nome, telefone, endereco, idade)
        {
            CPF = cPF;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCPF: {CPF}";
        }
    }
}
