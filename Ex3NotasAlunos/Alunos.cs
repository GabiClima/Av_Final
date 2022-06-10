using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3NotasAlunos
{
    internal class Alunos
    {
        public string NomeAluno { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }


        //o construtor dos dados dentro da classe, recebe os parametros do programa principal e atribui aos atributos da classe
        public Alunos(string nomeAluno, double nota1, double nota2, double nota3)
        {
            NomeAluno = nomeAluno;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        //metodo que realiza a soma das notas digitadas
        public double SomaNotas()
        {
            return Nota1 + Nota2 + Nota3;

        }


        //metodo que compara se a soma das notas foram maior ou igual a 60, para poder dar a mensagem de aprovado ou reprovado
        public string ReprovadoAprovado()
        {
            if (SomaNotas() >= 60)
            {
                return "Parabéns voce foi APROVADO, sua nota final foi " + SomaNotas();
            }
            else
            {
                return "Aluno REPROVADO, sua nota final foi " + SomaNotas() + " faltaram " + (60 - SomaNotas()) + " pontos para ser aprovado!";
            }
        }


        //override é uma impressão padrão
        public override string ToString()
        {
            return "***************DADOS DO ALUNO*****************\n"
                   + "Aluno(a) "
                   + NomeAluno.ToUpper() + "\n"
                   + "\n Nota 1 "
                   + Nota1.ToString("F2")
                   + "\n Nota 2 "
                   + Nota2.ToString("F2")
                   + "\n Nota 3 "
                   + Nota3.ToString("F2") + "\n\n"
                   + "***************APROVADO OU REPROVADO*****************\n"
                   + ReprovadoAprovado()
                   + "\n\n";

        }

    }
}
