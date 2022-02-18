using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairScript : MonoBehaviour
{

    public GameObject portalCrosshair;
    public LayerMask portalWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, portalWall))
        {
                portalCrosshair.SetActive(true);
   
        }
        else
        {
            portalCrosshair.SetActive(false);
        }
}
}

