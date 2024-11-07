using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public int health = 100;  // Vida do jogador

    public AudioClip damageSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    
    //Quando o Jogador colidir com o obstáculo
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Obstáculo"))
        {
            health -= 20;  // Reduz a vida
            Debug.Log("Colidiu com obstáculo! Vida: " + health);
            audioSource.PlayOneShot(damageSound);
        }
    }
}
