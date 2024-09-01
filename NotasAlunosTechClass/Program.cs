using System;

namespace NotasAlunosTechClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string sep = new string('-', 50);
            Console.WriteLine("Programa para Calcular a média Ponderada");
            Console.WriteLine(sep);

            Console.Write("Digite o Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite 1° Nota: ");
            double nota1 = double.Parse(Console.ReadLine());


            Console.Write("Digite 2° Nota: ");
            double nota2= double.Parse(Console.ReadLine());

            Console.Write("Digite 3° Nota: ");
            double nota3 = double.Parse(Console.ReadLine());


            NotasAlunos notasAlunos = new NotasAlunos(nome, nota1, nota2, nota3);

            double mediaPonderada = notasAlunos.CalculaMediaPonderada();
            
            Console.WriteLine(sep);

            if (mediaPonderada >= 60.0)

            {
                Console.WriteLine("Parabéns voce foi APROVADO!");
            }

            else {
                Console.WriteLine("Oh não, não desanime continue estudando! Você está REPROVADO");
            }


            Console.WriteLine(notasAlunos);
            Console.WriteLine(sep);
        }
    }
}
