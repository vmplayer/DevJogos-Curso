/*
EXERCÍCIO 1:
Crie uma variável que diga que uma lâmpada está ligada ou não.
Exemplo:
boot lampadaLigada = true;
OU
string lampadaLigada = "Ligada"

SE a lâmpada estiver ligada, imprimir "A lâmpada está ligada."
SE NÃO, imprimir "A lâmpada está desligada."

EXERCÍCIO 2
Um dia após ser dividido entre: manhã, tarde, noite e madrugada.
Manhã é antes de 12h e igual ou menor que 18h horas.
Tarde é a a partir 12h e pouco antes das 18h.
Noite é a partir das 18h, até um pouco antes da Meia-Noite (0h).
Madrugada é a partir da Meia-Noite (0h), até um pouco antes das 6h.

Crie uma variável chamada 'hora' e atribua um número inteiro a ela, de 0 a 23 (ex: 5). Através de um if, else if e else, imprima se é de manhã, tarde, noite ou madrugada.
*/

using System;

public class Exercicio4
{
    public static void Main (String[] args) 
    {
        bool lampadaLigada = true;

        if (lampadaLigada) {
        Console.WriteLine("A lampada esta ligada.");
        }else{
            Console.WriteLine("A lampada esta desligada.");
        }

        int hora = 16;

        if(hora >= 6 && hora < 12);
        {
            Console.WriteLine("Ainda é manhã.");
        }else if (hora >= 12 && hora < 18) 
        {
            Console.WriteLine("Ja e tarde.");
        }else if (hora >= 18 && hora < 00)
        {
            Console.WriteLine("Chegou a noite.");
        }else{
            Console.WriteLine("Estamos de madrugada.");
        }
    }
}
