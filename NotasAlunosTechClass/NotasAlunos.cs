public class NotasAlunos
{
    private string _nome;
    private double _nota1, _nota2, _nota3;
    private double _pontosFaltantes = 60;
    private double _media;

    
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

   
    public double Nota1
    {
        get { return _nota1; }
        set { _nota1 = value; }
    }

    public double Nota2
    {
        get { return _nota2; }
        set { _nota2 = value; }
    }

    public double Nota3
    {
        get { return _nota3; }
        set { _nota3 = value; }
    }

    
    public double Media
    {
        get { return _media; }
        set { _media = value; } 
    }

   
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
