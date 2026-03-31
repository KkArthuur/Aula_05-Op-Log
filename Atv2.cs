/* Ref (5 pontos)
2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante.

Nome:Arthur Campos Rocha
*/
public static class Atv2
{
    public static void Executar()
    {
        Console.Clear();

        Console.WriteLine("digite uma letra: ");
        string letra = Console.ReadLine()!;

        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
        {
            Console.WriteLine($"A letra {letra} é uma vogal!");

        }
        else
        {
            Console.WriteLine($"A letra {letra} é uma consoante");
        }
    }
}