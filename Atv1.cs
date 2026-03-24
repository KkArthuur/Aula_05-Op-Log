/*Ref (5 pontos)
1 - Faça um programa que calcule e apresente o valor do volume de uma lata,
sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores
de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
Nome:Arthur Campos Rocha
*/
public static class Atv1
{
    public static void Executar()
    {
        double raio;
        double altura;
        double pi = 3.14159;
        double volume;

        Console.Clear();

        Console.WriteLine("Valor do Raio: ");
        raio = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Valor da Altura: ");
        altura = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        volume = pi * (raio * raio) * altura;

        Console.WriteLine($"O volume da lata é de {volume}cm³");

        Console.WriteLine();
    }
}
