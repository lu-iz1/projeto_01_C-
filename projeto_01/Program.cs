using System;

namespace projeto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string aluno;
            double nota1, nota2, media;

            Console.WriteLine("Digite o nome do Aluno: ");
            aluno = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 6)
                Console.WriteLine("A média do aluno " + aluno + " foi " + media + " Está Aprovado");
            else
                Console.WriteLine("A média do aluno " + aluno + " foi " + media + "Está Reprovado");
        }
    }
}
