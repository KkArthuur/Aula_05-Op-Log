/*Ref. (10 pontos)
8 - Crie um programa que faça 5 perguntas para uma pessoa sobre um crime.
As perguntas são:
 "Telefonou para a vítima?"
 "Esteve no local do crime?"
 "Mora perto da vítima?"
 "Devia para a vítima?"
 "Já trabalhou com a vítima?"
O programa deve, no final, emitir uma classificação sobre a participação da pessoa no
crime. Se a pessoa responder positivamente a 2 questões, ela deve ser
classificada/exibida como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino".
Caso contrário, ela será classificada como "Inocente".
Aluno:Arthur Campos Rocha
*/

public static class Atv8
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Você telefonou para a vítima?");
        string r1 = Console.ReadLine()!;

        Console.WriteLine("Você esteve no local do crime?");
        string r2 = Console.ReadLine()!;

        Console.WriteLine("Você mora perto da vítima");
        string r3 = Console.ReadLine()!;

        Console.WriteLine("Você devia para a vítima");
        string r4 = Console.ReadLine()!;

        Console.WriteLine("Você já trabalhou com a vítima");
        string r5 = Console.ReadLine()!;

        double nR = 0;

        if(r1 == "sim" || r1 == "SIM" || r1 == "Sim")
        {
            nR ++;
        }
            else if(r2 == "sim" || r2 == "SIM" || r2 == "Sim")
                {
                    nR ++;
                }
                else if(r3 == "sim" || r3 == "SIM" || r3 == "Sim")
                    {
                        nR ++;
                    }
                    else if(r4 == "sim" || r4 == "SIM" || r4 == "Sim")
                        {
                           nR ++;
                        }
                         else if(r5 == "sim" || r5 == "SIM" || r5 == "Sim")
                            {
                                nR ++;
                            }
        if (nR == 5)
        {
            Console.WriteLine("Você é o assassino");
        }
        else if(nR <=4 && nR >= 3)
        {
            Console.WriteLine("Você é cúmplice");
        }
        else if(nR == 2)
        {
            Console.WriteLine("Você é suspeito");
        }
        else 
        {
            Console.WriteLine("Você é inocente");
        }
    }
}