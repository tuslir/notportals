using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    float bulletSpeed = 20f;

    void Update()
    {

        transform.position += PortalGun.portalGun.transform.forward * Time.deltaTime * bulletSpeed;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "PortalGun") Destroy(gameObject);
    }
}
