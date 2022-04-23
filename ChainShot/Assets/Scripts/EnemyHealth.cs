using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private bool isHit = false;
    private Vector3 startPosition;
    private EnemyMover mover;

    // Start is called before the first frame update
    void Start()
    {
        mover = GetComponent<EnemyMover>();
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            mover.IncreaseSpeed();
            transform.position = startPosition;
            this.gameObject.SetActive(false);
            //increase score
        }
        if (other.tag == "Deathwall")
        {
            transform.position = startPosition;
            this.gameObject.SetActive(false);
        }
    }
}
