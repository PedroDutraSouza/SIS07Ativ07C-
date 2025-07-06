using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        int numero;

        Console.WriteLine("Digite números inteiros para somar (um número negativo encerra o programa):");

        // O laço sempre lê o primeiro número
        do
        {
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Adiciona à soma apenas se o número não for negativo
            if (numero >= 0)
            {
                soma += numero;
            }
        } while (numero >= 0); // Continua apenas se o número inserido for positivo ou zero

        Console.WriteLine($"A soma dos números inseridos (excluindo o negativo) é: {soma}");
    }
}
