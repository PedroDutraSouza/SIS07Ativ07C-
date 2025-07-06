using System;

class Program
{
    static void Main(string[] args)
    {
        string senhaCorreta = "senha123";
        string senhaDigitada;
        int tentativas = 0;
        const int maxTentativas = 3;

        // O laço sempre executa a primeira tentativa
        do
        {
            tentativas++;
            Console.Write($"Tentativa {tentativas}/{maxTentativas}. Digite a senha: ");
            senhaDigitada = Console.ReadLine();

            if (senhaDigitada == senhaCorreta)
            {
                Console.WriteLine("Sucesso! Senha correta.");
                break; // Sai do laço se a senha estiver correta
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
            }

        } while (tentativas < maxTentativas); // Continua se a senha estiver errada E as tentativas não se esgotaram

        // Mensagem de falha se o laço terminou por excesso de tentativas
        if (senhaDigitada != senhaCorreta && tentativas >= maxTentativas)
        {
            Console.WriteLine("Você excedeu o número de tentativas. Acesso bloqueado.");
        }
    }
}