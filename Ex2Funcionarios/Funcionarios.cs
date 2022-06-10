using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Funcionarios
{
    internal class Funcionarios
    {


        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }


        //o construtor dos dados dentro da classe, recebe os parametros do programa principal e atribui aos atributos da classe
        public Funcionarios(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }


        //metodo que vai calcular meu salario liquido
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }


        //metodo void que vai substituir o valor de salarioBruto con base no percentual de aumento
        public void AumentoSalario(double perct_aumento)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * perct_aumento / 100.00);
        }


        //override é uma impressão padrão
        public override string ToString()
        {
            return "***************DADOS DO COLABORADOR*****************\n"
                   + "Funcuinario "
                   + Nome.ToUpper() + "\n"
                   + "\n Salario Bruto R$ "
                   + SalarioBruto.ToString("F2")
                   + "\n Imposto "
                   + Imposto.ToString("F2")
                   + "\n Salario liquido "
                   + SalarioLiquido().ToString("F2") + "\n\n"
                   +"----------------------------------------------------"
                   + "\n\n";

        }

    
    }
}
