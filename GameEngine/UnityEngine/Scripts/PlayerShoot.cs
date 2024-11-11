using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab do projétil
    public Transform shootPoint; // Ponto de onde o projétil será lançado
    public float projectileSpeed = 20f; // Velocidade do projétil

    void Update()
    {
        // Verifica se o jogador pressionou a tecla para disparar (pode ser "Espaço")
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(); // Executa o método de disparo
        }
    }

    void Shoot()
    {
        // Instancia o projétil no ponto de disparo com rotação padrão
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);

        // Adiciona velocidade ao projétil na direção em que o jogador está olhando
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * projectileSpeed; // Define a velocidade do projétil
        }
    }
}
