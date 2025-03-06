using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFPS : MonoBehaviour
{
   

    public TournerHelices scriptHelice;
    
    void Start()
    {

    }
    void Update()
    {
        if (scriptHelice.vitesseRotation.y > 1)
        {
            transform.localPosition = new Vector3(0, 0, 1.8f);
            transform.Rotate(new Vector3(0, 0, Random.Range(-.01f, .01f)));
            transform.Translate(new Vector3(Random.Range(-.020f, .020f), Random.Range(-.010f, .010f), Random.Range(-.01f, .01f)));
        }

    }

}
