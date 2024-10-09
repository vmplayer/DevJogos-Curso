using System;

class Condicionais {
    
    static void Main (String[] args) {

        //Condicionais são estruturas que permitem que um bloco de código só seja executado SE obedecer uma determinada condição.

        bool temCarteira = true;

        //SE eu tenho carteira
        if (temCarteira)
        //Bloco de código que será executado se a condição for verdadeira
        {Console.WriteLine("Voce pode dirigir!");
        //Se não tenho carteira
        }else{
          //Bloco de código executado se a condição for falsa.
            Console.WriteLine("Voce nao pode dirigir!");
        }
    }
}
