using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour
{
    public GameObject Teleport ;

    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.tag == "Player") 
        {
            other.transform.position = Teleport.transform.position;
        }
    }
}
