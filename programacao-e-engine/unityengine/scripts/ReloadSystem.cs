using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadSystem : MonoBehaviour
{
    public AudioClip reloadSound; // Som de coleta
    private AudioSource audioSource;
    private PlayerStats playerStats; // Referência ao PlayerStats
    private int ammunition;

    private void Start()
    {
        ammunition = 15;
        audioSource = gameObject.AddComponent<AudioSource>();
        playerStats = GetComponent<PlayerStats>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Amm"))
        {
            ammunition += 5;
            playerStats.Addammunition(5); // Adiciona 10 pontos (pode ajustar o valor como preferir)

            audioSource.PlayOneShot(reloadSound);
            Destroy(other.gameObject);  // Remove o coletável
            Debug.Log("Máximo de munição: " + ammunition);
        }
    }
}
