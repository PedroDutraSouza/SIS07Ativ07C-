using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa a variável que armazenará a soma
        int soma = 0;
        int numero = 0;

        Console.WriteLine("Digite números inteiros para somar (um número negativo encerra o programa):");

        // Laço infinito que será interrompido internamente
        while (true)
        {
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Verifica se o número é negativo para encerrar
            if (numero < 0)
            {
                break; // Interrompe o laço
            }

            // Adiciona o número à soma
            soma += numero;
        }

        // Exibe a soma final dos números não negativos
        Console.WriteLine($"A soma dos números inseridos (excluindo o negativo) é: {soma}");
    }
}