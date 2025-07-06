using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa a variável que armazenará a soma
        int soma = 0;
        int numero;

        Console.WriteLine("Digite uma sequência de números inteiros (digite 0 para parar e somar):");

        // O laço continua indefinidamente até ser interrompido com 'break'
        while (true)
        {
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Se o número for 0, interrompe o laço
            if (numero == 0)
            {
                break;
            }

            // Adiciona o número à soma total
            soma += numero;
        }

        // Exibe a soma final
        Console.WriteLine($"A soma dos números inseridos é: {soma}");
    }
}
