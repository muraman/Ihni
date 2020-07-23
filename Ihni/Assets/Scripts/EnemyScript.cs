using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public float enemyHealth;

    float enemyCurrentHealth;

    void Start()
    {
        enemyCurrentHealth = enemyHealth;
    }

    void Update()
    {
        if(enemyCurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        enemyCurrentHealth -= damage;
    }
}
