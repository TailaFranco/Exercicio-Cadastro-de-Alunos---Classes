using System;


namespace Aula_02_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {   
           Console.WriteLine("Sistema de Cadastro de Alunos");
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Digite o curso do aluno");
            aluno1.curso = Console.ReadLine();

            Console.WriteLine("Digite o RG do aluno");
            aluno1.rg = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Média final do aluno");
            aluno1.mediaFinal = float.Parse(Console.ReadLine());

           Console.WriteLine("Digite o valor da mensalidade");
           aluno1.valorMensalidade = float.Parse(Console.ReadLine());

           Console.WriteLine("Digite se o aluno é bolsista ou não");
           string resposta = Console.ReadLine();
           if(resposta == "s")
            {
                aluno1.bolsista = true;
            }
            else
            {
                 aluno1.bolsista = false;
            }
            
            // Menu
            int opcao = 0;
            do
            {
                Console.WriteLine("Escolha uma opção válida");
                Console.WriteLine("[1] Ver Média final do aluno");
                Console.WriteLine("[2] Ver Valor da Mensalidade do aluno");
                Console.WriteLine("[0] Sair");
                opcao = int.Parse(Console.ReadLine());

            switch (opcao)
                {
                case 1:
                    Console.WriteLine($"A média final do aluno é: {aluno1.mediaFinal}");
                    break;
                case 2:
                Console.WriteLine($"A Mensalidade aluno é: {aluno1.VerMensalidade(aluno1.bolsista, aluno1.mediaFinal)}");
                break;
                case 0:
                Console.WriteLine("Obrigado por acessar");
                break;
                default:
                    break;
                }
            

            } while (opcao != 0);



        }
    }
}
