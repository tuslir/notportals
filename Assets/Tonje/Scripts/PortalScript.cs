using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{


    GameObject bluePortal, orangePortal, player;

    void Start()
    {
        bluePortal = GameObject.FindGameObjectWithTag("BluePortal");
        orangePortal = GameObject.FindGameObjectWithTag("OrangePortal");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag=="BluePortal" && other.CompareTag("Player"))
        {
            player.transform.position = orangePortal.transform.position;
        }

        else if (gameObject.tag == "OrangePortal" && other.CompareTag("Player"))
        {
            player.transform.position = bluePortal.transform.position;
        }

    }
}
