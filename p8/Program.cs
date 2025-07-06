using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro para ver sua tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int multiplicador = 1;

        Console.WriteLine($"Tabuada do {numero}:");

        // O laço inicia a execução sem verificar a condição primeiro
        do
        {
            int resultado = numero * multiplicador;
            Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
            multiplicador++;
        } while (multiplicador <= 10); // Continua enquanto o multiplicador for até 10
    }
}
