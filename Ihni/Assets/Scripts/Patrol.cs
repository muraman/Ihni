using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    public float moveSpeed;

    [SerializeField]
    public int range;

    Transform player;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if(distanceToPlayer < range)
        {
            Chase();
        }
        else
        {
            StopChasing();
        }
    }

    void Chase()
    {
        if(transform.position.x < player.position.x)
        {
            rb.velocity = new Vector2(moveSpeed, 0);
            
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
            
            transform.localScale = new Vector2(-1, 1);
        }
    }

    void StopChasing()
    {
        rb.velocity = Vector2.zero;
    }

}
