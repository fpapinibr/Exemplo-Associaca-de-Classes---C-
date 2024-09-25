using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Associacaò
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Endereco endereco = new Endereco("Precide São Martim", "Rua", "Araraquara", "SP", "Jardim Santa Clara", 14811380, 126, "Portaria");
            //Pessoa pessoa = new Pessoa("Fabio", "190", endereco, 52);

            Console.WriteLine("Exemplo de Pessoa:\n\n");
            Pessoa pessoa = new Pessoa("Fabio", "190", new Endereco("Precide São Martim", "Rua", "Araraquara", "SP", "Jardim Santa Clara", 14811380, 126, "Portaria"), 52);
            Console.WriteLine(pessoa.ToString());

            Console.WriteLine("\n\nExemplo de Pessoa Física:\n\n");
            PessoaFisica pessoaFisica = new PessoaFisica("Fabio", "190", new Endereco("Precide São Martim", "Rua", "Araraquara", "SP", "Jardim Santa Clara", 14811380, 126, "Portaria"), 52, "19633652318");
            Console.WriteLine(pessoaFisica.ToString());
            Console.ReadKey();
        }
    }
}
