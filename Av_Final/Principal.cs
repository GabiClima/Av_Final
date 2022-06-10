using System;

namespace Ex1Retangulo
{


    class Ex1Retangulo
    {




        static void Main(string[] args)
        {

            Console.WriteLine("De quantos Retangulos voce quer a area, perimetro e diagonal ?");
            int qtdRetangulos = int.Parse(Console.ReadLine());//varivavel que vai guardar o valor que define o tamanho do meu vetor



            Retangulo[] calculo = new Retangulo[qtdRetangulos];//definição do meu meu vetor

            for (int i = 0; i < qtdRetangulos; i++)// for que vai navegar no meu vetor para poder guardar os dados do retangulo
            {

                Console.WriteLine();
                Console.WriteLine(" ************DADOS DO " + (i + 1) + "° RETANGULO ***********");
                Console.WriteLine();

                Console.WriteLine("Digite a altura do retangulo : ");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a largura do retangulo : ");
                double largura = double.Parse(Console.ReadLine());

                // cria o objeto composto da classe vinculado ao indice do vetor, passando os parametros para o construtor atribuir aos atributos da classe
                calculo[i] = new Retangulo(altura, largura);
            }



            for (int i = 0; i < qtdRetangulos; i++)// for que vai navegar no meu vetor para poder imprimir o override difinido na classe retangulo
            {
                Console.WriteLine();
                Console.WriteLine(" ************ " + (i + 1) + "° RETANGULO ***********");
                Console.WriteLine();
                Console.WriteLine(calculo[i]);
            }

        }
    }
}
