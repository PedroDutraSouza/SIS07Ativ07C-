using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        int numero;

        Console.WriteLine("Digite uma sequência de números inteiros (digite 0 para parar e somar):");

        // O laço executa, solicitando um número, e depois verifica se deve continuar
        do
        {
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            soma += numero; // Adiciona o número à soma
        } while (numero != 0); // Para quando o número digitado for 0

        // Como o 0 final é somado, o resultado não é alterado.
        Console.WriteLine($"A soma dos números inseridos é: {soma}");
    }
}