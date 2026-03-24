/*Ref. (5 pontos)
9 - Escreva um programa que leia um número e verifique se ele é positivo,
negativo ou zero.
Nome:Arthur Campos Rocha
*/

public static class Atv9
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Valor: ");
        double num = double.Parse(Console.ReadLine()!);
        if (num > 0 )
        {
        Console.WriteLine("Este número é positivo ");
        }
        else if (num < 0 )
        {
        Console.WriteLine("Este número é negativo ");
        }
        else
        Console.WriteLine("Este número é igual a 0 ");
    }
}