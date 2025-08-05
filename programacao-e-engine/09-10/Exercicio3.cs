using System;

public class Exercicio3
{
    public static void Main (String[] args)
    {
        /*

        Para entrar na faculdade, uma pessoa precisa:

        1- ter 18 anos ou mais;
        2- ter concluído o ensino médio;
        3- não estar em outra faculdade;

        Faça um Console.WriteLine que contenha a equação, usando operadores lógicos, que diz se uma pessoa pode ou não entrar na faculdade.
        */

        int idade = 19;
        bool maioridade = idade >= 18;
        bool ensmed = true;
        bool maisdeum = false;

        Console.WriteLine($"Voce terminou o ensino medio? {ensmed}. Voce tem a idade necessaria? {maioridade}. Voce se matriculou em outra faculdade? {maisdeum}.");

        if(maioridade && ensmed && maisdeum) {
            Console.WriteLine("Desculpe, voce nao pode cursar a faculdade!");
        }else{
            Console.WriteLine("Voce pode cursar a faculdade!");
        }
        
    }
}
