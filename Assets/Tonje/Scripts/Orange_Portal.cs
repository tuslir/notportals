using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange_Portal : MonoBehaviour
{
    GameObject bluePortal, player;

    void Start()
    {
        bluePortal = GameObject.FindGameObjectWithTag("BluePortal");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = bluePortal.transform.position;
        }
    }

}
