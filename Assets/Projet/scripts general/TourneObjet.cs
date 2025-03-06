using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourneObjet : MonoBehaviour
{
   

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Rotate(0, Time.deltaTime*300, 0, Space.World);


    }
}
