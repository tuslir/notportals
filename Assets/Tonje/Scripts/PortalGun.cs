using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGun : MonoBehaviour
{

    public GameObject bluePortal, orangePortal, portalSpawn;
    static public GameObject portalGun;

    public float range = 7f;
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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, range))
        {
            Debug.Log(hit.collider.gameObject.name);
            bluePortal.transform.position = hit.point;
            bluePortal.transform.rotation = hit.transform.rotation;
        }






    }

    void ShootOrangePortal()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, range))
        {
            Debug.Log(hit.collider.gameObject.name);
            orangePortal.transform.position = hit.point;
            orangePortal.transform.rotation = hit.transform.rotation;


        }


    }


}
