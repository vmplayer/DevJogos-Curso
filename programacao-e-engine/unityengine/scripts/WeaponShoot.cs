using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShoot : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Botão esquerdo do mouse
        {
            animator.SetTrigger("Shoot");
        }
    }
}
