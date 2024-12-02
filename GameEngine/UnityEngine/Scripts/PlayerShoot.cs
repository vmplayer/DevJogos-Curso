using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab do projétil
    public Transform shootPoint; // Ponto de onde o projétil será lançado
    public float projectileSpeed = 20f; // Velocidade do projétil
    public AudioClip shootSound; // Som de coleta
    private AudioSource audioSource; 
    private PlayerStats playerStats; //Referência ao PlayerStats
    
    private void Start()
    {
        // Obtém o componente de áudio
        audioSource = gameObject.AddComponent<AudioSource>();
        playerStats =  GetComponent<PlayerStats>();
    }
    
    void Update()
    {
        // Verifica se o jogador pressionou a tecla para disparar (pode ser "Botão Esquerdo")
        if (Input.GetMouseButtonDown(0))
        {
            Shoot(); // Executa o método de disparo
            playerStats.UpdateAmmText(); //Atualiza o número de munições no PlayerStats
        }
    }

    void Shoot()
    {
        playerStats.ammunition -= 1;
        if(playerStats.ammunition <= 0)
        {
            playerStats.ammunition = 0;
            Debug.Log("Você está sem munição! Recarregue.");
        } else {
        // Instancia o projétil no ponto de disparo com rotação padrão
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);

        // Adiciona velocidade ao projétil na direção em que o jogador está olhando
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = shootPoint.forward * projectileSpeed; // Define a velocidade do projétil
            audioSource.PlayOneShot(shootSound);
        }
        }
    }
}
