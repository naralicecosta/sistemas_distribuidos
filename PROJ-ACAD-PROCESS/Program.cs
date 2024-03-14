using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista para armazenar os números
        List<int> numeros = new List<int>();

        // Loop for para adicionar números de 1 a 9 à lista
        for (int i = 1; i <= 9; i++)
        {
            numeros.Add(i);
        }

        // Imprimindo a lista
        Console.WriteLine("Lista de números de 1 a 9:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}

 //////////////////////////////////
 var numeros = Enumerable.Range(1, 1000);
 var pares = numeros.asParallel() Where(n => n % 2 == 0).toArray();
 console WriteLine($"Quantidade de números pares: {pares.Length}")
















