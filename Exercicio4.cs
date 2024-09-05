using System;

public class Exercicio4
{
    public void Execute()
    {
        while (true)
        {
            Console.WriteLine("Escolha a sequência que deseja verificar:");
            Console.WriteLine("a) 1, 3, 5, 7, ___");
            Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ___");
            Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ___");
            Console.WriteLine("d) 4, 16, 36, 64, ____");
            Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ____");
            Console.WriteLine("f) 2, 10, 12, 16, 17, 18, 19, ____");
            Console.WriteLine("Digite a letra da questão que quer saber o último número da sequência.");

            char escolha = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (escolha)
            {
                case 'a':
                    SequenciaA();
                    break;
                case 'b':
                    SequenciaB();
                    break;
                case 'c':
                    SequenciaC();
                    break;
                case 'd':
                    SequenciaD();
                    break;
                case 'e':
                    SequenciaE();
                    break;
                case 'f':
                    SequenciaF();
                    break;
                default:
                    Console.WriteLine("Não existe essa alternativa.\n");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para acessar outra questão...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private void SequenciaA()
    {
        Console.WriteLine("Sequência a) 1, 3, 5, 7, ___");

        int ultimoNumero = 7;
        int proximoNumero = ultimoNumero + 2;
        Console.WriteLine($"O próximo número é: {proximoNumero}");
    }

    private void SequenciaB()
    {
        Console.WriteLine("Sequência b) 2, 4, 8, 16, 32, 64, ___");

        int ultimoNumero = 64;
        int proximoNumero = ultimoNumero * 2;
        Console.WriteLine($"O próximo número é: {proximoNumero}");
    }

    private void SequenciaC()
    {
        Console.WriteLine("Sequência c) 0, 1, 4, 9, 16, 25, 36, ___");

        int ultimoNumero = 36;
        int proximoNumero = (int)Math.Pow(Math.Sqrt(ultimoNumero) + 1, 2);
        Console.WriteLine($"O próximo número é: {proximoNumero}");
    }

    private void SequenciaD()
    {
        Console.WriteLine("Sequência d) 4, 16, 36, 64, ____");

        int ultimoNumero = 64;
        int proximoNumero = (int)Math.Pow(Math.Sqrt(ultimoNumero) + 2, 2);
        Console.WriteLine($"O próximo número é: {proximoNumero}");
    }

    private void SequenciaE()
    {
        Console.WriteLine("Sequência e) 1, 1, 2, 3, 5, 8, ____");

        int penultimoNumero = 8;
        int ultimoNumero = 5;
        int proximoNumero = penultimoNumero + ultimoNumero;
        Console.WriteLine($"O próximo número é: {proximoNumero}");
    }

    private void SequenciaF()
    {
        Console.WriteLine("Sequência f) 2, 10, 12, 16, 17, 18, 19, ____");

        int ultimoNumero = 19;
        int proximoNumero = ultimoNumero + 1;
        Console.WriteLine($"O próximo número é: {proximoNumero}");
    }
}
