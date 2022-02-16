using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody rb;

    public float moveSpeed;

    void Start()
    {


        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * x * Time.deltaTime * moveSpeed);
        transform.Translate(Vector3.forward * z * Time.deltaTime * moveSpeed);



    }

}
