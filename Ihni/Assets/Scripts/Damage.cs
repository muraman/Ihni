using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private PlayerHealth player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Controller").GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            player.TakeDamage(5);
        }
    }
}