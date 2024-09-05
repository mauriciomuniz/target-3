using System;

public class Exercicio2
{
    public void Execute()
    {
        Console.WriteLine("Escolha a opção:");
        Console.WriteLine("1. Informar uma string");
        Console.WriteLine("2. Usar uma string previamente definida");
        Console.Write("Digite o número da opção: ");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Digite uma string para verificar a quantidade de letras 'a' (maiúscula e minúscula):");
                string inputUsuario = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputUsuario))
                {
                    Console.WriteLine("Entrada inválida. A string não pode ser nula ou vazia.");
                    return; 
                }

                int quantidadeUsuario = ContarLetrasA(inputUsuario);
                Console.WriteLine($"A letra 'a' ocorre {quantidadeUsuario} vezes na string informada.");
                break;

            case 2:
               string inputPredefinida = "Aqui está uma string de exemplo com várias letras a, incluindo maiúsculas e minúsculas.";
                int quantidadePredefinida = ContarLetrasA(inputPredefinida);
                Console.WriteLine($"A letra 'a' ocorre {quantidadePredefinida} vezes na string definida.");
                break;

            default:
                Console.WriteLine("Escolha inválida.");
                break;
        }
    }

    private int ContarLetrasA(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }
        return count;
    }
}
