using System;

class Exercicio11
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos identificar qual sua faixa");
        Console.WriteLine("Digite sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 12)
        {
            Console.WriteLine($"{idade} é um criança");
        }
        else if (idade <= 17)
        {
            Console.WriteLine($"{idade}é um adolescente");
        }
        else if (idade <= 59)
        {
            Console.WriteLine($"{idade}é adulto");
        }
        else if (idade <= 60)
        {
            Console.WriteLine($"{idade}é idoso");
        }

    }


}