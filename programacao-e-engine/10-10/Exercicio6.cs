using System;

class Execicio6 
{
    static void Main (String[] args) 
    {
        int tempo = 9;

        while (tempo >= 0){
            if(tempo == 0){
                Console.WriteLine("Booom!");
            }else if(tempo % 2 == 0) {
                Console.WriteLine("Tic");
            }else{
                Console.WriteLine("Tac");
            }
            tempo --;
        }
    }
}
