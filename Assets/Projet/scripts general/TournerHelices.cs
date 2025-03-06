using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TournerHelices : MonoBehaviour
{
    public Vector3 vitesseRotation;
    public float vitesseRotationMax;

    public float acceleration;

    public bool moteurEnMarche;

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            moteurEnMarche = !moteurEnMarche;
        }

        if (moteurEnMarche)
        {
            if (vitesseRotation.y < vitesseRotationMax)
            {
                vitesseRotation.y += acceleration;
            }
            //transform.Rotate(0f,2f,0f, Space.Self);
            // ou
            transform.Rotate(vitesseRotation, Space.Self);
        }
        else
        {
            if (vitesseRotation.y > 0)
            {
                vitesseRotation.y -= acceleration;
            }
            
            transform.Rotate(vitesseRotation, Space.Self);
        }        
    }
}
