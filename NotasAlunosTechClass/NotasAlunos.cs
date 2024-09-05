public class NotasAlunos
{
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
    public double Media;
    private const double PontosFaltantes = 60;

    public NotasAlunos(string nome, double nota1, double nota2, double nota3)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
        Nota3 = nota3;
    }

    public double CalculaMediaPonderada()
    {
        Media = (Nota1 * 30/100) + (Nota2 * 35/100) + (Nota3 * 35/100);
        return Media;
    }

    public override string ToString()
    {
        return $"Sua média foi: {CalculaMediaPonderada():F2}\n";
    }
}
