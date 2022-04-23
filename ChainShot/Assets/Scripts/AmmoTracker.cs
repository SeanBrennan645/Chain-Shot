using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoTracker : MonoBehaviour
{
    [SerializeField] PlayerProjectile projectile;
    [SerializeField] LevelManager levelManager;

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
        }
        else if (other.tag == "Deathwall")
        {
            ammoEmpty = true;
            projectile.NoLongerFire();
            levelManager.GameOver();
        }
    }
}
