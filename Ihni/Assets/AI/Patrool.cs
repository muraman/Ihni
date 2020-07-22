using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrool : MonoBehaviour
{
    public float speed;

    public int positionOfPatrool;
    public Transform point;
    bool moveingRight = true;

    Transform player;
    public float stoppingDistance;

    bool chill = false;
    bool angry = false;
    bool goBack = false;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, point.position) < positionOfPatrool && angry == false)
        {
            chill = true;
        }

        if(Vector2.Distance(transform.position, player.position) < stoppingDistance)
        {
            angry = true;
            chill = false;
            goBack = false;
        }

        if(Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            goBack = true;
            angry = false;
        }

        if(chill == true)
        {
            Chill();
        }

        else if (angry == true)
        {
            Angry();
        }
        else if (goBack == true)
        {
            GoBack();
        }
    }

    void Chill()
    {
        if(transform.position.x > point.position.x + positionOfPatrool)
        {
            moveingRight = false;
        }

        else if (transform.position.x < point.position.x - positionOfPatrool)
        {
            moveingRight = true;
        }

        if(moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }

    void Angry()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        speed =+5;
    }
    void GoBack()
    {
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
    }
}
