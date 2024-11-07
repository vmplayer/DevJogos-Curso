using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public AudioClip collectSound;
    private AudioSource audioSource;

    public ParticleSystem collectEffect;

    private ParticleSystem copia;
    public int score = 0; //Armazena a pontuação do jogador

    private PlayerStats playerStats; //Referência ao PlayerStats

    private void Start()
    {
        //Obtém o componente de áudio
        audioSource = gameObject.AddComponent<AudioSource>();

        //Busca o componente PlayerStats no mesmo GameObject
        playerStats = GetComponent<PlayerStats>();
    }

    //Detecta colisão com o coletável
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coletavel"))
        {
            score += 10; //Aumenta a pontuação
            Destroy(other.gameObject); //Remove o coletável
            Debug.Log("Coletável obtido! Pontuação: " + score);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.CompareTag("Coletavel"))
        {
            playerStats.AddScore(10); //Adiciona a determinada quantia de pontos
            audioSource.PlayOneShot(collectSound);

            Instantiate(collectEffect, hit.transform.position, Quaternion.identity);
            copia = Instantiate(collectEffect, hit.transform.position, Quaternion.identity);

            copia.gameObject.SetActive(true);
            hit.gameObject.SetActive(false);
        }
    }
}
