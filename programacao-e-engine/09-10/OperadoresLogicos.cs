using System;

class OperadoresLogicos 
{
    static void Main (string[] args)
    {
        bool temCarteira = true;
        int idade = 22;
        bool maioridade = idade >= 18;

        Console.WriteLine($"Para poder dirigir, uma pessoa precisa ter carteira de motorista (CNH) e ter 18 anos ou mais.");
        Console.WriteLine($"Voce tem carteira de motorista? {temCarteira}");
        Console.WriteLine($"Voce atingiu a maioridade? {maioridade}");

        //OPERADOR LÓGICO E(AND): Retorna true apenas se todos forem true.
        //Apenas um único false já é o suficiente para que a equação se torne false.
        Console.WriteLine(temCarteira == true && maioridade == true);

        Console.WriteLine(true && true && true && false && true);

        /*
        true && true //True
        true && false //False
        false && true //False
        false && false //False
        */

        //OPERADOR LÓGICO OU (OR): Retorna False apenas se todos forem False. Apenas um único True já é o suficiente para que a equação se torne True.

        bool temTrabalho == true;
        bool economiza == true;
        bool investe == true;

        temTrabalho == true && economiza == true && investe == true

        //"temTrabalho && economiza && investe" tem o mesmo resultado que o código acima.

        bool nasceuHeredeiro = false;

        Console.WriteLine((temTrabalho && economiza && investe) || nasceuHerdeiro);

        //OPERADOR LÓGICO NÃO/NEGAÇÃO (NOT) (!): Inverte o estado. Se algo retorna true, ele transforma em False e vice-versa.

        /*
        !true //False
        !false //True
        */

        bool ligado = true;
        Console.WriteLine(ligado);
    }
}
