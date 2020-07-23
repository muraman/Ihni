using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTaker : MonoBehaviour
{
    [Range(1, 4)] [SerializeField] private int damage = 1;

    private PlayerHealth player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Controller").GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            player.TakeDamage(damage);
        }
    }

}