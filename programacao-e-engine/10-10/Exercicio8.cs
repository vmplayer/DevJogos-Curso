//Faça um array contendo seus 5 jogos favoritos.
//Imprima todo o Array
//Depois, imprima um por um.

using System;

class Exercicio8 {

    static void Main (String[] args) {

        string[] jogos = {"Hollow Knight: Voidheart Edition", "CoD: Black Ops II", "Grand Theft Auto: San Andreas", "Super Coleção 7.784 Jogos", "Celeste"};

        jogos[3] = "Resident Evil 4";

        Console.WriteLine("Ou vai ser esse aqui: {0}",jogos[0]);
        Console.WriteLine("Ou vai ser esse aqui: {0}", jogos[1]);
        Console.WriteLine("Ou vai ser esse aqui: {0}", jogos[2]);
        Console.WriteLine("Ou vai ser esse aqui: {0}", jogos[3]);
        Console.WriteLine("Entao pode ser esse: {0}", jogos[4]);
    }
}
