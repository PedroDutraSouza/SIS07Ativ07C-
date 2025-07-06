using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int contador = 0;

        Console.WriteLine($"Números pares entre 0 e {numero}:");

        // O bloco 'do' é executado pelo menos uma vez
        do
        {
            Console.WriteLine(contador);
            contador += 2; // Incrementa para o próximo par
        } while (contador <= numero); // A condição é checada no final
    }
}
