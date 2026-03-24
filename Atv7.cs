/*Ref. (15 pontos)
7 - Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg.
Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode
doar sangue ou não; caso não possa, diga o(s) motivo(s).

Nome:Arthur Campos Rocha
*/
public static class Atv7
{
    public static void Executar()
    {
        Console.Clear();
        Console.WriteLine("Digite sua idade: ");
        double idade = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine()!);

        if (idade >= 18 && idade <= 67 && peso > 60 )
        {
            Console.WriteLine("Sim você pode doar sangue");
        }
        else if (idade >= 18 && idade <= 67)
        {
            Console.WriteLine("Não, você não pode doar sangue, pois, seu peso é menor que 60kg");
        }
        else if ( peso > 60)
        {
            Console.WriteLine("Não, você não pode doar sangue, pois, sua idade é menor que 18 ou maior que 67");
        }
        else
        {
            Console.WriteLine("Não, você não pode doar sangue, pois, não atende a nenhum requisito");
        }

    }
}