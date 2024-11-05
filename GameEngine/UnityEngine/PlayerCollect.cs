using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public AudioClip collectSound;
    private AudioSource audioSource;

    public ParticleSystem collectEffect;

    private ParticleSystem copia;
    public int score = 0; //Armazena a pontuação do jogador

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
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

        if (hit.gameObject.CompareTag("item"))
        {
            Debug.Log("Item coletado!");

            audioSource.PlayOneShot(collectSound);

            Instantiate(collectEffect, hit.transform.position, Quaternion.identity);
            copia = Instantiate(collectEffect, hit.transform.position, Quaternion.identity);

            copia.gameObject.SetActive(true);
            hit.gameObject.SetActive(false);
        }
    }
}
