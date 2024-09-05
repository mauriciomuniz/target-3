using System;

public class Exercicio3
{
    public void Execute()
    {
        int INDICE = 12;
        int SOMA = 0;
        int K = 1;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine($"O valor final da variável SOMA é: {SOMA}");

        //resposta 65
    }
}
