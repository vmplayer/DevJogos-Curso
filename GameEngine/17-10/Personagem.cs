using System;

class Personagem 
{
    //Atriubutos - atributos são variáveis que minha classe usa.
    public string nome;
    public int forca;
    public int vida;

    //Construtor - é uma função/método que define como os objetos são criados. Ela é chamada toda vez que criamos um objeto com essa classe.
    public Personagem(string nomePersonagem, int forcaInicial, int vidaInicial) 
    {
        nome = nomePersonagem;
        forca = forcaInicial;
        vida = vidaInicial;
    }

    //Métodos - são as funções que representam o que o objeto dessa classe pode fazer.
    public void atacar() 
    {
        Console.WriteLine($"{nome} ataca com o {forca} pontos de forca.");
    }

    public void andar()
    {
        Console.WriteLine($"{nome} esta andando.");
    }

}

class Jogo
{
    //Tudo o que deve ser exibido só aparece dentro de um Main.
    static void Main (String[] args) 
    {
        //Criar um personagem.
        //Instanciar o objeto/Criar o objeto.
        Personagem personagem1 = new Personagem ("Bobalhao", 12, 100);

        //Usando os métodos dos personagens.
        personagem1.atacar();
        personagem1.andar();
    }
}
