using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSurveille : MonoBehaviour
{

    public Transform laCible;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // LookAt( un transform d'une cible )
        transform.LookAt(laCible);
    }
}
