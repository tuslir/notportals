using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGun : MonoBehaviour
{

    public float coolDownTime;
    public GameObject bluePortal, orangePortal, portalSpawn;

    static public GameObject portalGun;
    float shootSpeed = 10f;

    float range = 50f;
    Camera camera;

    void Start()
    {
        portalGun = gameObject;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))         //fires portal with LMB
        {
            ShootBluePortal();
        }

        if (Input.GetMouseButtonDown(1))
        {
            ShootOrangePortal();
        }

    }


    void ShootBluePortal()
    {
        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position + camera.transform.forward, camera.transform.forward, out hit, range))
        {
            bluePortal.transform.position = hit.point;
            bluePortal.transform.rotation = hit.transform.rotation;
        }


    }

    void ShootOrangePortal()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position + camera.transform.forward, camera.transform.forward, out hit, range))
        {
            orangePortal.transform.position = hit.transform.position;
            orangePortal.transform.rotation = hit.transform.rotation;

        }


    }


}
