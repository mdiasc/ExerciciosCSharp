using System;

class Exercicio09{
    public static void Main(string[] args){
        Console.WriteLine("Digite Um número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro número");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int calculo = numero1 / numero2;
        Console.WriteLine("O resultado da divisão é:" + calculo);
    }
}