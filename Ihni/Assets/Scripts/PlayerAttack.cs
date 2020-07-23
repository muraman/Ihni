using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPoint;
    public float attackRange;

    public LayerMask whatIsEnemy;

    public int damage;

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if(timeBtwAttack <= 0)
        {
            timeBtwAttack = startTimeBtwAttack;

            if(Input.GetButtonDown("Attack"))
            {
                IsAttacking();
                Invoke("IsNotAttacking", 0.1f);

                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, whatIsEnemy);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyScript>().TakeDamage(damage);
                }

            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void IsAttacking()
    {
        animator.SetBool("IsAttacking", true);
    }

    void IsNotAttacking()
    {
        animator.SetBool("IsAttacking", false);
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
