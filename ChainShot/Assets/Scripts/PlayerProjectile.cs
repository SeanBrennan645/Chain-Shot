using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    [SerializeField] GameObject Projectile;
    [SerializeField] float speed = 15.0f;

    private bool fired = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fired = true;
        }

        if(fired)
        {
            launchProjectile();
        }
    }

    void launchProjectile()
    {
        Projectile.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
