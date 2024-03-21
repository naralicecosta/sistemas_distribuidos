namespace Models; //esta conectado a pasta models //aluno esta na pasta de trabalho dntro da pasta models

public class Aluno(
    string nome, 
    int idade, 
    string curso,
    int matricula
    )
{

    public string Nome { get; set; } = nome;

    public int Idade { get; set; } = idade;

    public string Curso { get; set; } = curso;

    public int Matricula { get; set; } = matricula;

    public void ExibirInformacoes()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Nome: {Nome}, Idade {Idade}, curso{Curso}, Matricula {Matricula},");
        Console.ResetColor();
        
    }
}