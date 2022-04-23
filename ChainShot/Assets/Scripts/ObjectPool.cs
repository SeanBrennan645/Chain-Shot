using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Transform SpawnLocation;
    [SerializeField] float[] distanceRange = new float[2]; 
    [SerializeField] int poolSize = 5;
    [SerializeField] float spawnTimer = 1.0f;

    private GameObject[] pool;
    private void Awake()
    {
        PopulatePool();
    }

    private void PopulatePool()
    {
        pool = new GameObject[poolSize];

        for(int i = 0; i<pool.Length; i++)
        {
            pool[i] = Instantiate(enemy, SpawnLocation);
            pool[i].SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while(true)
        {
            EnableObjectInPool();
            yield return new WaitForSeconds(spawnTimer);
        }
    }

    private void EnableObjectInPool()
    {
        for(int i = 0; i<pool.Length; i++)
        {
            if(pool[i].activeInHierarchy == false)
            {
                pool[i].transform.position += new Vector3(Random.Range(distanceRange[0], distanceRange[1]), 0, 0);
                pool[i].SetActive(true);
                return;
            }
        }
    }
}
