using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Portal : MonoBehaviour
{

    GameObject orangePortal, player;

    void Start()
    {
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
