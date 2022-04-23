using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private Vector3 startPosition;
    private EnemyMover mover;
    private ScoreKeeper scoreKeeper;
    [SerializeField] int pointvalue = 50;

    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = GetComponentInParent<ScoreKeeper>();
        mover = GetComponent<EnemyMover>();
        startPosition = transform.position;
        startPosition -= new Vector3(startPosition.x, 0.0f, 0.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            mover.IncreaseSpeed();
            ResetEnemy();
            scoreKeeper.IncreaseScore(pointvalue);
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
