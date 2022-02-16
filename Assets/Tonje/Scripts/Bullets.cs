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

}
