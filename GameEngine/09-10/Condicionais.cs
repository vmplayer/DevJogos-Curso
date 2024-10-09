using System;

class Condicionais {
    
    static void Main (String[] args) {

        //Condicionais são estruturas que permitem que um bloco de código só seja executado SE obedecer uma determinada condição.

        bool temCarteira = false;
        bool maioridade = 21 >= 18;

        //SE eu tenho carteira
        if (temCarteira)
        //Bloco de código que será executado se a condição for verdadeira.
        {Console.WriteLine("Voce pode dirigir!");
        //OU
        }else if (!temCarteira && maioridade) {
            //Bloco de código executado quando apenas uma das condições for verdadeira.
            Console.WriteLine("Voce tem idade suficiente, mas nao tem carteira, portanto, voce nao pode dirigir.");
        //SENÃO
        }else{
            //Bloco de código executado quando ambas condições forem falsas.
            Console.WriteLine("Voce nao pode dirigir.");
        }
    }
}
