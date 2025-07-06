// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        // Define a senha correta
        string senhaCorreta = "senha123";

        // Inicializa o contador de tentativas
        int tentativas = 0;
        const int maxTentativas = 3; // Define o número máximo de tentativas como uma constante

        // O laço continua enquanto as tentativas forem menores que o máximo permitido
        while (tentativas < maxTentativas)
        {
            Console.Write($"Tentativa {tentativas + 1}/{maxTentativas}. Digite a senha: ");
            string senhaDigitada = Console.ReadLine();

            // Verifica se a senha está correta
            if (senhaDigitada == senhaCorreta)
            {
                Console.WriteLine("Sucesso! Senha correta.");
                return; // Encerra o programa com sucesso
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                // Incrementa o contador de tentativas
                tentativas++;
            }
        }

        // Se o laço terminar, significa que as tentativas se esgotaram
        Console.WriteLine("Você excedeu o número de tentativas. Acesso bloqueado.");
    }
}