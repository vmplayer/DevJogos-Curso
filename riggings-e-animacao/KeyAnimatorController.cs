using UnityEngine;

public class KeyAnimatorController : MonoBehaviour
{
    private Animator animator;
    private PlayerStats stats;

    void Start()
    {
        // Obtém o componente Animator do GameObject
        animator = GetComponent<Animator>();
        stats = GetComponent<PlayerStats>();
    }

    void Update()
    {
        // Detecta as teclas e dispara a animação correspondente
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("Walk");
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
        else if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetTrigger("Running");
        }
        else if(Input.GetKeyDown(KeyCode.Q) || stats.health <= 0)
        {
            animator.SetTrigger("Death");
        }
        /*else()
        {
            animator.SetTrigger("Stand By");
        }*/
    }
}
