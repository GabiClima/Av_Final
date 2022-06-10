using System;

namespace Ex3NotasAlunos
{


    class Ex3NotasAlunos
    {




        static void Main(string[] args)
        {

            Console.WriteLine("As notas de quantos alunos voce quer ? ");
            int qtdAlunos = int.Parse(Console.ReadLine());//varivavel que vai guardar o valor que define o tamanho do meu vetor


            Alunos[] alunos = new Alunos[qtdAlunos];//definição do meu meu vetor

            for (int i = 0; i < qtdAlunos; i++)// for para poder navegar no meu vetor 
            {

                Console.WriteLine(" ************DADOS DO " + (i + 1) + "° ALUNO ***********");
                Console.WriteLine("Digite o nome do aluno : ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a nota do 1º trimestre : (limite maximo da nota é 30)");
                double nota1 = double.Parse(Console.ReadLine());

                while (nota1 > 30)//while que vai rodar enquanto minha nota foi maior que 30
                {


                    if (nota1 > 30)// if que vai aparecer caso a nota continue sendo maior que 30
                    {
                        Console.WriteLine("Nota inválida, nota máxima é 30, digite novamente! ");
                        Console.WriteLine("Digite a nota do 1º trimestre : (limite maximo da nota é 30)");
                        nota1 = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Digite a nota do 2º trimestre : (limite maximo da nota é 35)");
                double nota2 = double.Parse(Console.ReadLine());

                while (nota2 > 35)//while que vai rodar enquanto minha nota foi maior que 35
                {


                    if (nota2 > 35)// if que vai aparecer caso a nota continue sendo maior que 35
                    {
                        Console.WriteLine("Nota inválida, nota máxima é 35, digite novamente! ");
                        Console.WriteLine("Digite a nota do 2º trimestre : (limite maximo da nota é 35)");
                        nota2 = double.Parse(Console.ReadLine());
                    }
                }


                Console.WriteLine("Digite a nota do 3º trimestre : (limite maximo da nota é 35)");
                double nota3 = double.Parse(Console.ReadLine());

                while (nota3 > 35)//while que vai rodar enquanto minha nota foi maior que 35
                {


                    if (nota3 > 35)// if que vai aparecer caso a nota continue sendo maior que 30
                    {
                        Console.WriteLine("Nota inválida, nota máxima é 35, digite novamente! ");
                        Console.WriteLine("Digite a nota do 3º trimestre : (limite maximo da nota é 35)");
                        nota3 = double.Parse(Console.ReadLine());
                    }

                }

                Console.WriteLine();
                Console.WriteLine();


                // cria o objeto composto da classe vinculado ao indice do vetor, passando os parametros para o construtor atribuir aos atributos da classe
                alunos[i] = new Alunos(nome, nota1, nota2, nota3);

            }


            for (int i = 0; i < qtdAlunos; i++)//for que vai navegar no meu vetor imprimindo os dados que eu defini no meu override
            {
                Console.WriteLine();
                Console.WriteLine(" ************NOTA FINAL DO " + (i + 1) + "° ALUNO ***********");
                Console.WriteLine();

                //imprime o override que eu criei na classe Alunos
                Console.WriteLine();
                Console.WriteLine(alunos[i]);
                Console.WriteLine();

                
            }


            


        }
    }
}
