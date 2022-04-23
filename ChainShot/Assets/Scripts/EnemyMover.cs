using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] float speed = 0.2f;
    [SerializeField] [Range(0.1f, 30.0f)] float[] speedRange = new float[2];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    public void IncreaseSpeed()
    {
        if (speed <= speedRange[1])
        {
            speed += 0.5f;
        }
        else
        {
            speed = speedRange[1];
        }
    }
}
