using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário um número para ver a tabuada
        Console.Write("Digite um número inteiro para ver sua tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Inicializa o multiplicador
        int multiplicador = 1;

        Console.WriteLine($"Tabuada do {numero}:");

        // O laço executa enquanto o multiplicador for menor ou igual a 10
        while (multiplicador <= 10)
        {
            // Calcula e exibe o resultado da multiplicação
            int resultado = numero * multiplicador;
            Console.WriteLine($"{numero} x {multiplicador} = {resultado}");

            // Incrementa o multiplicador para a próxima iteração
            multiplicador++;
        }
    }
}