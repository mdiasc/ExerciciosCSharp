using System;
class Program02
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa de soma");
        Console.WriteLine("Digite um Número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro Número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int soma = numero1 + numero2;
        Console.WriteLine("A soma dos resultados é:" + soma);
    }

}