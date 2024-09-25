using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Associacaò
{
     class Pessoa
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public Endereco endereco { get; set; }
        public int idade { get; set; }

        public Pessoa(string nome, string telefone, Endereco endereco, int idade)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
            this.idade = idade;
        }

        public override string ToString()
        {
            return $"Dados da Pessoa:\nNome: {nome}"+
                   $"\nTelefone: {telefone}"+
                   $"\nIdade: {idade}"+
                   $"\n{endereco.ToString()}";
        }

        public Pessoa()
        {
        }

    }
}
