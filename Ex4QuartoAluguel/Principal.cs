using System;

namespace Ex4QuartoAluguel
{
    class Ex4QuartoAluguel
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Quantos quartos tem disponiveis ? ");
            int qtdQuartos = int.Parse(Console.ReadLine());//varivavel que vai guardar o valor que define o tamanho do meu vetor

            Hospede[] quarto = new Hospede[qtdQuartos];//definição do meu meu vetor
            DadosHospedagem[] hospedagem = new DadosHospedagem[qtdQuartos];

            for (int i = 0; i < qtdQuartos; i++)// for para poder navegar no meu vetor, onde eu delimito o valor dele com a variavel qtdQuartos
            {
                //DADOS DO HOSPEDE
                Console.WriteLine();
                Console.WriteLine(" * ***********COLOQUE OS DADOS DO " + (i + 1) + "° HÓSPEDE * **********");
                Console.WriteLine();


                //Pergunto os dados do hospede, os dados irão ser perguntas a quantidades que vezes que meu for foi definido:
                Console.WriteLine("Qual o nome do hospede : ");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual o Endereço do hospede : ");
                string endereco = Console.ReadLine();
                Console.WriteLine("Qual o CPF do hospede : ");
                double cpf = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual o Telefone do hospede : ");
                double telefone = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a data de nascimento do hospede : ");
                string dataNasc = Console.ReadLine();
                Console.WriteLine("Qual o E-mail do hospede : ");
                string email = Console.ReadLine();
                Console.WriteLine("Qual o telefone de contato de um conhecido do hospede : ");
                double contatoPessoa = double.Parse(Console.ReadLine());


                // cria o objeto composto da classe vinculado ao indice do vetor, passando os parametros para o construtor atribuir aos atributos da classe
                quarto[i] = new Hospede(nome, endereco, cpf, telefone, dataNasc, email, contatoPessoa);

            }


            for (int i = 0; i < qtdQuartos; i++)// outro for para poder navegar no vetor para perguntar os dados da hospedagem
            {
                //DADOS DA HOSPEDAGEM
                Console.WriteLine();
                Console.WriteLine("************COLOQUE OS DADOS DA HOSPEDAGEM***********");
                Console.WriteLine();

                //dados da hospedagem:
                Console.WriteLine("Qual o valor da hospedagem : ");
                double valorQuarto = double.Parse(Console.ReadLine());
                Console.WriteLine("Periodo da Estadia : ");
                int periodoEstadia = int.Parse(Console.ReadLine());

                // cria o objeto composto da classe vinculado ao indice do vetor, passando os parametros para o construtor atribuir aos atributos da classe
                hospedagem[i] = new DadosHospedagem(valorQuarto, periodoEstadia);
            }


            for (int i = 0; i < qtdQuartos; i++)// for para poder navegar no vetor e imprimir os dados dos hospedes
            {
                Console.WriteLine();
                Console.WriteLine("************RELATORIO DOS DADOS DO " + (i + 1) + "° HÓSPEDE ***********");
                Console.WriteLine();

                //imprime o override que eu criei na classe Hospede
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine(quarto[i]);






            }

            for (int i = 0; i < qtdQuartos; i++)// for para poder navegar no vetor e imprimir os dados da hospedagem
            {
                Console.WriteLine();
                Console.WriteLine("************RELATORIO DOS DADOS DO " + (i + 1) + "° HÓSPEDE ***********");
                Console.WriteLine();


                //imprime o override que eu criei na class DadosHospedagem
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine(hospedagem[i]);


            }




        }
    }
}