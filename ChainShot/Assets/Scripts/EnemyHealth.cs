using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private Vector3 startPosition;
    private EnemyMover mover;

    // Start is called before the first frame update
    void Start()
    {
        mover = GetComponent<EnemyMover>();
        startPosition = transform.position;
        startPosition -= new Vector3(startPosition.x, 0.0f, 0.0f);
        Debug.Log("Start Pos: " + startPosition);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            mover.IncreaseSpeed();
            ResetEnemy();
            //increase score
        }
        if (other.tag == "Deathwall")
        {
            ResetEnemy();
        }
    }

    private void ResetEnemy()
    {
        transform.position = startPosition;
        this.gameObject.SetActive(false);
    }
}
