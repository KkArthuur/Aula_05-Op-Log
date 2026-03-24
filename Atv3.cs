/*Ref. (10 pontos)
3 - Escreva um programa que receba três números inteiros e mostre eles em ordem
crescente.
Nome:Arthur Campos Rocha
*/

public static class Atv3
{
    public static void Executar()
    {
        Console.Clear();

        Console.WriteLine("Digite o Valor 1: ");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o Valor 2: ");
        int num2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o Valor 3: ");
        int num3 = int.Parse(Console.ReadLine()!);

        int menorN = 0;
        int medioN = 0;
        int maiorN = 0;

        //Número 1
        //P descobrir se o 1 é o menor
        if (num1 > num2 || num1 > num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                maiorN = num1;
            }
            else
            {
                medioN = num1;
            }
        }
        else
        {
            menorN = num1;
        }


        //Número 2
        //P descobrir se o 2 é o menor
        if (num2 > num1 || num2 > num3)
        {
            if (num2 > num1 && num2 > num3)
            {
                maiorN = num2;
            }
            else
            {
                medioN = num2;
            }
        }

        else
        {
            menorN = num2;
        }

        //Número 3
        //P descobrir se o 3 é o menor
        if (num3 > num1 || num3 > num2)
        {
            if (num3 > num1 && num3 > num2)
            {
                maiorN = num3;
            }
            else
            {
                medioN = num3;
            }
        }

        else
        {
            menorN = num3;
        }

        Console.WriteLine($"Os valores em ordem crescente são: \n {menorN}, {medioN} e {maiorN}. ");
    }
}