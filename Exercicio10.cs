using System;

class Exercicio10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Será que este ano é bissexto? ");
        Console.WriteLine("Digite um ano ");
        int ano = Convert.ToInt32(Console.ReadLine());
        bool bissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        
        if (bissexto)
        {
            Console.WriteLine($"{ano} é um ano bissexto");
        }
        else 
        {
            Console.WriteLine($"{ano} não é um ano bissexto");
        }

    }

    
}