/*Ref. (10 pontos)
6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado.
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°,
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°,
o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo.
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.
Nome:Arthur Campos Rocha
*/

public static class Atv6
{
    public static void Executar()
    {
        Console.Clear();

        Console.WriteLine("Digite o 1º ângulo: ");
        double ang1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine();

        Console.WriteLine("Digite o 2º ângulo: ");
        double ang2 = double.Parse(Console.ReadLine()!);
        Console.WriteLine();

        Console.WriteLine("Digite o 3º ângulo: ");
        double ang3 = double.Parse(Console.ReadLine()!);
        Console.WriteLine();

        double Sa = ang1 + ang2 + ang3;

        if (Sa != 180)
        {
            Console.WriteLine("Não é um triângulo ");
        }
        else if (ang1 == 90 || ang2 == 90 || ang3 == 90)
        {
            Console.WriteLine("É um triângulo retângulo ");
            Console.WriteLine($"De ângulos {ang1}, {ang2} e {ang3}.");
        }
        else if (ang1 > 90 || ang2 > 90 || ang3 > 90)
        {
            Console.WriteLine("É um triângulo obtusângulo ");
            Console.WriteLine($"De ângulos {ang1}, {ang2} e {ang3}.");
        }
        else if (ang1 < 90 && ang2 < 90 && ang3 < 90)
        {
            Console.WriteLine("É um triângulo acutângulo");
            Console.WriteLine($"De ângulos {ang1}, {ang2} e {ang3}.");
        }


    }
}