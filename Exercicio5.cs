using System;

public class Exercicio5
{
    public void Execute()
    {

        Console.WriteLine (
            "Para determinar qual dos três interruptores controla a lâmpada, usaremos a análise da temperatura da lâmpada enquanto está ligada.\n\n" +
            "O processo consiste em três passos:\n\n" +
            "1. Ligaremos o primeiro interruptor e aguardaremos alguns minutos.\n" +
            "2. Desligaremos o primeiro interruptor e ligaremos o segundo interruptor.\n" +
            "3. Entraremos na sala imediatamente após ligar o segundo interruptor.\n\n" +
            "Existem três possibilidades: a lâmpada pode estar acesa, apagada e fria, ou apagada e quente.\n\n" +
            "Se a lâmpada estiver apagada e quente, o interruptor correto é o número 1, indicando que a lâmpada esteve ligada por algum tempo.\n" +
            "Se a lâmpada estiver acesa, o interruptor correto é o 2, pois foi o que acabamos de ligar.\n" +
            "Se a lâmpada estiver apagada e fria, o interruptor correto é o 3, sugerindo que não foi ligada por um tempo considerável."
        );


    }

}