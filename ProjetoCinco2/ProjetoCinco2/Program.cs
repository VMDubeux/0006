using System;
using System.Collections.Generic;

namespace Exercicio2
{
    internal class QuintoProjeto2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do raio do círculo em m²:");
            float raio = float.Parse(Console.ReadLine());
            double area = (double)Math.PI * Math.Pow(raio, 2.0);
            Console.WriteLine($"O valor da área é de: {area}m²!");
        }
    }
}