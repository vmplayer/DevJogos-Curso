using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class EmemyStats : MonoBehaviour
{
    public int Health; //Vida do oponente
    public ParticleSystem explosao; //Referência à partícula original
    private ParticleSystem copia; //Cópia da partícula

    void Start()
    {
        Health = 100;
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
            TakeDamage(10);
            Destroy(other.gameObject);

            if (Health <= 0)
            {
                Destroy(this.gameObject);

                copia = Instantiate(explosao, this.transform.position, Quaternion.identity);
            }
        }
    }
}
