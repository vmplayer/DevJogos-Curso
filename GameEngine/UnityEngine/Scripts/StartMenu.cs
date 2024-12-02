using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenu; //Referência ao Canvas do menu de pausa
    private int Jogo;

    //Sair do jogo
    public void QuitGame()
    {
        //Na Unity, este comando encerra o jogo compilado (só funciona depois que o jogo estiver pronto, não na Unity)
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }

    //Esse método é chamado no final da animação
    public void TrocaCena()
    {
        SceneManager.LoadScene(Jogo);
    }
}
