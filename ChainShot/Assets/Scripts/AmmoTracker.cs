﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoTracker : MonoBehaviour
{
    [SerializeField] PlayerProjectile projectile;

    private bool isThrown = false;
    private bool ammoEmpty = false;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    public void Shoot()
    {
        isThrown = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            isThrown = false;
            transform.position = startPosition;
            projectile.StopProjectile();
            Debug.Log("Enemy was hit!");
        }
        else if (other.tag == "Deathwall")
        {
            ammoEmpty = true;
            Debug.Log("DeathWall was hit!");
        }
    }
}
