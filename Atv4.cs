/*Ref (15 pontos)
4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente,
tal que 0 é a menor nota e 10 a maior, e imprimir o conceito equivalente
(A, B, C, D ou E), conforme a seguinte tabela:
 A - nota >= 8,5 e nota <= 10
 B - nota >= 7 e nota < 8,5
 C - nota >= 5 e nota < 7
 D - nota >= 3 e nota < 5
 E - nota < 3
Nome:Arthur Campos Rocha
*/


public static class Atv4
{
    public static void Executar()
    {
        Console.Clear();

        Console.WriteLine("Digite a 1ª nota: ");
        double n1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite a 2ª nota: ");
        double n2 = double.Parse(Console.ReadLine()!);

        double mediaNs = (n1 + n2)/2;
    //Nota A
        if (mediaNs <= 10 && mediaNs >= 8.5)
        {
            Console.WriteLine($"A média Final é {mediaNs} logo nota:A");
        }
    //Nota B
        else
        {
            if (mediaNs < 8.5 && mediaNs >=7)
            {
                Console.WriteLine($"A média Final é {mediaNs} logo nota:B");
            }
            else 
            {
            //Nota C
                if (mediaNs < 7 && mediaNs >=5)
                {
                    Console.WriteLine($"A média Final é {mediaNs} logo nota:C");
                }
                else
                {
                //Nota D
                    if (mediaNs < 5 && mediaNs >= 3)
                    {
                        Console.WriteLine($"A média Final é {mediaNs} logo nota:D");
                    }
                    else
                    {
                    //Nota E
                        if (mediaNs < 3 && mediaNs >= 0)
                        {
                            Console.WriteLine($"A média Final é {mediaNs} logo nota:E");
                        }
                    }
                }
            }
        }
    }
}