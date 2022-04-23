using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private bool isHit = false;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("I've been hit!!");
            this.enabled = false;
            //increase score
        }
        if (other.tag == "Deathwall")
        {
            transform.position = startPosition;
            this.enabled = false;
        }
    }
}
