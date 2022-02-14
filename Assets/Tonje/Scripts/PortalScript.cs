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
        if (other.CompareTag("Player"))
        {
            player.transform.position = orangePortal.transform.position;
        }
    }
}
