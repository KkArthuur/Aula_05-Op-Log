/*Ref (15 pontos)
5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia,
e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número
de maçãs compradas, calcule e escreva o valor total da compra.
Nome:Arthur Campos Rocha
*/

public static class Atv5
{
    public static void Executar()
    {
        Console.Clear();

        Console.WriteLine("Digite o numero de maçãs compradas: ");
        double macas = double.Parse(Console.ReadLine()!);
        double custoT;

        if (macas < 12)
        {
            custoT = 0.3 * macas;
        }
        else
        {
            custoT = 0.25 * macas;
        }
        Console.WriteLine($"Custo Total foi de: {custoT} reais");
    }
}