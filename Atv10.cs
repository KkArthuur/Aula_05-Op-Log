/*Ref. (5 pontos)
10 - Escreva um programa que leia um número e verifique se ele é par ou ímpar.
Nome:Arthur Campos Rocha
*/

public static class Atv10
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Valor: ");
        double num = double.Parse(Console.ReadLine()!);
        if ((num % 2) == 0 )
        {
        Console.WriteLine("Este número é par ");
        }
        else
        {
        Console.WriteLine("Este número é impar ");
        }
    }
    
}