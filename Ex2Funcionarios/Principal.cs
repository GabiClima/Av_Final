using System;

namespace Ex2Funcionarios
{


    class Ex2Funcionarios
    {




        static void Main(string[] args)
        {
            Console.WriteLine("Voce quer os dados de quantos funcionários  ?");
            int qtdFuncionarios = int.Parse(Console.ReadLine());//varivavel que vai guardar o valor que define o tamanho do meu vetor

            Funcionarios[] colaborador  = new Funcionarios[qtdFuncionarios];//definição do meu meu vetor



            for (int i = 0; i < qtdFuncionarios; i++)// for para poder navegar no meu vetor para perguntar e guardar os dados dos funcionarios 
            {
                //Dados do colaborador:
                Console.WriteLine(" ************DADOS DO " + (i + 1) + "° COLABORADOR ***********");
                Console.WriteLine("Digite o nome do colaborador : ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o salário bruto do colaborador : ");
                double salarioBruto = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o imposto encima do salário do colaborador : ");
                double imposto = double.Parse(Console.ReadLine());

                // cria o objeto composto da classe vinculado ao indice do vetor, passando os parametros para o construtor atribuir aos atributos da classe
                colaborador[i] = new Funcionarios(nome, salarioBruto, imposto);

                Console.WriteLine();
                Console.WriteLine(colaborador[i]);
                Console.WriteLine();

            }

            


            for (int i = 0; i < qtdFuncionarios; i++)//for que vai navegar no meu vetor para poder perguntar o porcentagem do aumento do salario
            {
                Console.WriteLine();
                Console.WriteLine(" ************AUMENTO DE SALÁRIO DO " + (i + 1) + "° COLABORADOR ***********");
                Console.WriteLine();

                Console.WriteLine("Quantos % quer de aumento encima do salário bruto atual ");
                double percent_aumento = double.Parse(Console.ReadLine());
                colaborador[i].AumentoSalario(percent_aumento);

                Console.WriteLine();
                Console.WriteLine(colaborador[i]);
                Console.WriteLine();

            }

            
        }
    }
}
