using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4QuartoAluguel
{
    internal class DadosHospedagem
    {
        public double ValorQuarto { get; set; }

        public int PeriodoEstadia { get; set; }

        //o construtor dos dados dentro da classe, recebe os parametros do programa principal e atribui aos atributos da classe
        public DadosHospedagem(double valorQuarto, int periodoEstadia)
        {
            ValorQuarto = valorQuarto;
            PeriodoEstadia = periodoEstadia;
        }

        //metodo que vai calcular o valor total a pagar pela estadia
        public double TotalPagar()
        {
            return ValorQuarto * PeriodoEstadia;
        }


        //override é uma impressão padrão
        public override string ToString()
        {
            return " * ***********DADOS DA HOSPEDAGEM***********\n\n"
                   + "Valor do quarto R$".ToUpper()
                   + ValorQuarto.ToString("F2") + "\n"
                   + "Periodo da estadia ".ToUpper()
                   + PeriodoEstadia + "\n"
                   + "Valor total a pagar R$".ToUpper()
                   + TotalPagar().ToString("F2") + "\n";
        }
    }
}
