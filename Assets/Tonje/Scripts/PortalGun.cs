using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGun : MonoBehaviour
{

    public float coolDownTime;
    public GameObject bluePortal, orangePortal, portalSpawn;

    bool blueExist = false;
    bool orangeExist = false;

    static public GameObject portalGun;

    void Start()
    {
        portalGun = gameObject;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && !blueExist)         //fires portal with LMB
        {
            ShootBluePortal();
        }

        if (Input.GetMouseButtonDown(1) && !orangeExist)
        {
            ShootOrangePortal();
        }

    }


    void ShootBluePortal()
    {
        Instantiate(bluePortal, portalSpawn.transform.position, Quaternion.identity);

    }

    void ShootOrangePortal()
    {
        Instantiate(orangePortal, portalSpawn.transform.position, Quaternion.identity);
    }


}
