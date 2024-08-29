using System;

namespace NotasAlunosTechClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotasAlunos notasAlunos = new NotasAlunos();
            string sep = new string('-', 50);
            Console.WriteLine("Programa para Calcular a média Ponderada");
            Console.WriteLine(sep);

            Console.Write("Digite o Nome do aluno: ");
            notasAlunos.Nome = Console.ReadLine();

            Console.Write("Digite 1° Nota: ");
            notasAlunos.Nota1 = double.Parse(Console.ReadLine());


            Console.Write("Digite 2° Nota: ");
            notasAlunos.Nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite 3° Nota: ");
            notasAlunos.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine(sep);

            Console.WriteLine($"Sua media foi: {notasAlunos.CalculaMedia()}");
            Console.WriteLine($"Faltaram: {notasAlunos.CalculaPontosFaltantes()}");


            Console.WriteLine(sep);
        }
    }
}
