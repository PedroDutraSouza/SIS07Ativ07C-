using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário um número inteiro positivo
        Console.Write("Digite um número inteiro positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Inicializa o contador para o primeiro número par
        int contador = 0;

        Console.WriteLine($"Números pares entre 0 e {numero}:");

        // O laço continua enquanto o contador for menor ou igual ao número inserido
        while (contador <= numero)
        {
            Console.WriteLine(contador);
            // Incrementa o contador de 2 em 2 para obter o próximo número par
            contador += 2;
        }
    }
}
