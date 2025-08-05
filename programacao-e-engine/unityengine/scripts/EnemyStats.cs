using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class EmemyStats : MonoBehaviour
{
    public int Health; //Vida do oponente
    public ParticleSystem explosao; //Referência à partícula original
    private ParticleSystem copia; //Cópia da partícula
    
    public GameObject player; //Referência ao jogador
    private PlayerStats playerStats; //Referência ao PlayerStats

    void Start()
    {
        Health = 100; //Define o valor da vida 
        playerStats = player.GetComponent<PlayerStats>(); //Declara o PlayerStats
    }

    // Método para atualizar a vida
    public void TakeDamage(int damage)
    {
        
        Health -= damage;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Proj"))
        {
            TakeDamage(70); //Efeutará o dano
            Destroy(other.gameObject); //Destrói a munição do disparo

            if (Health <= 0)
            {
                Destroy(this.gameObject); //Destrói o oponente
                playerStats.AddScore(50); //Adiciona pontuação para o jogador
                Debug.Log("O Inimigo foi retrogrado");

                copia = Instantiate(explosao, this.transform.position, Quaternion.identity); //Copia a partícula
            }
        }
    }
}
