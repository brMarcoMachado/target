using System;

class Program
{
    static void Main()
    {
        // Solicita o número do usuário
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número pertence à sequência de Fibonacci
        if (Fibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    // Função que verifica se um número pertence à sequência de Fibonacci
    static bool Fibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        // Se o número for 0 ou 1, ele pertence à sequência
        if (numero == a || numero == b)
        {
            return true;
        }

        int proximo = a + b;

        // Calcula a sequência até encontrar um valor maior ou igual ao número informado
        while (proximo <= numero)
        {
            if (proximo == numero)
            {
                return true;
            }

            // Atualiza os valores de a e b para calcular o próximo valor da sequência
            a = b;
            b = proximo;
            proximo = a + b;
        }

        // Se não encontrou o número na sequência, retorna false
        return false;
    }
}
