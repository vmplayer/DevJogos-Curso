using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioClip collectSound; // Som de coleta
    private AudioSource audioSource;

    public ParticleSystem collectEffect; //Efeito visual de coleta

    private ParticleSystem copia; //Cópia de partícula

        private void Start()
    {
        // Obtém o componente de áudio
        audioSource = gameObject.AddComponent<AudioSource>();

    }

    // Método chamado automaticamente quando o jogador colide com outro objeto
    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Verifica se o objeto com o qual colidimos possui a tag "item"
        if (hit.gameObject.CompareTag("item"))
        {
            // Exibe uma mensagem no console indicando a colisão
            Debug.Log("Item coletado!");

            // Aqui você pode adicionar outras interações, como efeitos sonoros, pontos, etc.
            // Toca o som de coleta
            audioSource.PlayOneShot(collectSound);

            //Ativa o efeito de partículas na posição do objeto coletado
            Instantiate(collectEffect, hit.transform.position, Quaternion.identity);
            copia = Instantiate(collectEffect, hit.transform.position, Quaternion.identity);

            copia.gameObject.SetActive(true);
            
            // Desativa o item coletado
            hit.gameObject.SetActive(false);
        }
    }
}
