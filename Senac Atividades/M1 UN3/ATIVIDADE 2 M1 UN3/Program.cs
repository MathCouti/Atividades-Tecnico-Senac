using System;

namespace ATIVIDADE_2_M1_UN3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade,dia,mes,ano;
            Console.WriteLine("Qual Seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual sua data de nascimento?");
            Console.WriteLine("Dia:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua data de nascimento?");
            Console.WriteLine("Mês:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua data de nascimento?");
            Console.WriteLine("Ano:");
            ano = int.Parse(Console.ReadLine());
            idade= 2022 - ano;
            if(idade > 18){
            Console.WriteLine("Sugestão de senha: " + idade + nome);
            }
            else{
            Console.WriteLine("Sugestão de senha: "+ nome + idade);
            }
        }
    }
}
