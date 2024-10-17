//Crie uma classe chamada Inimigo. Pense em quais atributos o inimigo deve ter, e o que ele deve fazer (ou seja, seus métodos). Depois que criar esta classe, crie um objeto com ela, dentro da classe Jogo e chame os métodos.

using System;

class inimigo
{
    //Atributos
    public string nome;
    public int forca;
    public int vida;

    //Construtor
    public inimigo (string nomeInimigo, int forcaInimigo, int vidaInimigo)
    {
        nome = nomeInimigo;
        forca = forcaInimigo;
        vida = vidaInimigo;
    }

    //Métodos
    public void desviar()
    {
        Console.WriteLine($"O {nome} consegue desviar e volta para seu turno.");
    }

    public void contraatk()
    {
        Console.WriteLine($"O {nome} contra-ataca com {forca} pontos de forca, voce recebe dano e continua no turno do seu oponente.");
    }
}

class Jogo
{
    static void Main (String[] args)
    {
        inimigo inimigo1 = new inimigo ("Agiota", 23, 100);

        inimigo1.desviar();
        inimigo1.contraatk();
    }
}
