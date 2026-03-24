using System.Runtime.CompilerServices;

public static class Exemplo1
{
    public static void Executar()
    {
        double nota;
        double frequencia;

        Console.Clear();
        Console.WriteLine("Digite a nota do aluno: ");
        nota = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Digite a frequencia do aluno: ");
        frequencia = double.Parse(Console.ReadLine()!);

        if (nota >= 7)
        {
            if (frequencia >= 75)
            {
                Console.WriteLine();
                Console.WriteLine("Aluno Aprovado!");
            }
            else
        {
                Console.WriteLine();
                Console.WriteLine("Aluno Reprovado!");
        }
        }
        
    }
}