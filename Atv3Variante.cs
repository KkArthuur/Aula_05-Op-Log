public static class Atv3Variante
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

        int aux = 0;
        if (num1 > num2)
        {
            aux = num1;
            num1 = num2;
            num2 = aux;
        }
        if (num1 > num3)
        {
            aux = num1;
            num1 = num3;
            num3 = aux;
        }
        if (num2 > num3)
        {
            aux = num2;
            num2 = num3;
            num3 = aux;
        }

        Console.WriteLine($"Os valores em ordem crescente são: \n {num1}, {num2} e {num3}. ");
    }
}