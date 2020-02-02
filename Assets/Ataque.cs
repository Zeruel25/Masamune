using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public AudioSource controlador;

    public AudioClip clipAtk;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }
    
    void Attack()
    {
        //comienza la animación de ataque
        animator.SetTrigger("Ataque");

        //detectar colisión con enemigos
        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitenemies) 
        {
            Debug.Log("Pegaste a" + enemy.name);
        }
    }

   void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public void  OnHit() {
        controlador.PlayOneShot(clipAtk);
    }

}