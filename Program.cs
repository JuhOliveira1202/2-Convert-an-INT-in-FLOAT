// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static int LerNumero()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    public static float Converter(float a)
    {
        a = (-32) / 1.8F;
        return a;
    }

    public static void Escrever(float valor)
    {
        Console.WriteLine(valor);
    }

    public static void Main(string[] args)
    {
        float valor;
        valor = LerNumero();
        valor = Converter(valor);
        Escrever(valor);
    }
}
