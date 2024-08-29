using System;

namespace NotasAlunosTechClass
{
    public class NotasAlunos
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double PontosFaltantes = 60;
        public double Resultado;

        public double CalculaMedia()
        {
            
            Resultado = (Nota1 * 30 / 100) + (Nota2 * 35 / 100) + (Nota3 * 35 / 100);

            if (Resultado >= PontosFaltantes)
            {
                Console.WriteLine($"Parabéns, sua nota foi: {Resultado:F2}. Você está APROVADO.");
            }
            else
            {
                Console.WriteLine($"Oh não, não desanime. Sua nota foi: {Resultado:F2}. Você está REPROVADO.");
            }

            return Resultado;
        }

        public double CalculaPontosFaltantes()
        {
           
            if (Resultado < PontosFaltantes)
            {
                double pontos = PontosFaltantes - Resultado;
                Console.WriteLine($"Você precisa de mais {pontos:F2} pontos para ser aprovado.");
                return pontos;
            }
            else
            {
                
                Console.WriteLine("Nenhum ponto faltante, você está aprovado.");
                return 0;
            }
        }
    }
}


