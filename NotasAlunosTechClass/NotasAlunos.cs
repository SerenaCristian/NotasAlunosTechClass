using System;

namespace NotasAlunosTechClass
{
    public class NotasAlunos
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double PontosFaltantes = 60;
        public double Media;

        public NotasAlunos(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;

        }

        public double CalculaMediaPonderada()
        {

            Media = (Nota1 * 30 / 100) + (Nota2 * 35 / 100) + (Nota3 * 35 / 100);

            return Media;
        }
        public double CalculaPontosFaltantes()
        {
            if (Media < PontosFaltantes)
            {
                return PontosFaltantes - Media;
            }
            else
            {
                return 0; 
            }
        }

        public override string ToString() 
        
        {
            return $"Sua media foi: {CalculaMediaPonderada():F2}\n" +
                   $"Faltaram: {CalculaPontosFaltantes()}";
        }
    }
}


