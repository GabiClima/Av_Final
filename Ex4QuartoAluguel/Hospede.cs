using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4QuartoAluguel
{
    internal class Hospede
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Cpf { get; set; }
        public double Telefone { get; set; }
        public string DataNasc { get; set; }
        public string Email { get; set; }
        public double ContatoPessoa { get; set; }


        //o construtor dos dados dentro da classe, recebe os parametros do programa principal e atribui aos atributos da classe
        public Hospede(string nome, string endereco, double cpf, double telefone, string dataNasc, string email, double contatoPessoa)
        {
            Nome = nome;
            Endereco = endereco;
            Cpf = Cpf;
            Telefone = telefone;
            DataNasc = dataNasc;
            Email = email;
            ContatoPessoa = contatoPessoa;
        }


        //override é uma impressão padrão
        public override string ToString()
        {
            return " * ***********DADOS DO HÓSPEDE***********\n\n"
                   + "Nome do Hospede ".ToUpper()
                   + Nome.ToUpper() + "\n"
                   + "CPF do Hospede ".ToUpper()
                   + Cpf + "\n"
                   + "Telefone do Hospede ".ToUpper()
                   + Telefone + "\n"
                   + "Data de Nascimento do Hospede ".ToUpper()
                   + DataNasc + "\n"
                   + "Email do Hospede ".ToUpper()
                   + Email.ToUpper() + "\n"
                   + "Contato de um conhecido do Hospede ".ToUpper()
                   + ContatoPessoa + "\n";
        }
    }
}
