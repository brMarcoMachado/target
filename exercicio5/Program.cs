using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário uma string
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        // Variável para armazenar a string invertida
        string invertida = "";

        // Percorre a string original de trás para frente
        for (int i = input.Length - 1; i >= 0; i--)
        {
            invertida += input[i]; // Concatena cada caractere na nova string
        }

        // Exibe a string invertida
        Console.WriteLine($"String invertida: {invertida}");
    }
}
