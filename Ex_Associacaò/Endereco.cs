using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Associacaò
{
    internal class Endereco
    {
        public string Logradouro { set;  get; }
        public string Tipo_logradouro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public Endereco(string logradouro, string tipo_logradouro, string localidade, string uF, string bairro, int cEP, int numero, string complemento)
        {
            Logradouro = logradouro;
            Tipo_logradouro = tipo_logradouro;
            Localidade = localidade;
            UF = uF;
            Bairro = bairro;
            CEP = cEP;
            Numero = numero;
            Complemento = complemento;
        }

        public override string ToString()
        {
            return $"Dados do Endereco:\n{Tipo_logradouro} {Logradouro}, {Numero} - {Complemento}" +
                   $"\n{Bairro} - {Localidade} - {UF}" +
                   $"\n{CEP}";
        }
    }
}
