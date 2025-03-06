using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDistFixe : MonoBehaviour
{
    public GameObject laCible;
    public Vector3 laDistance;

    // Update is called once per frame
    void Update()
    {
        transform.position = laCible.transform.position + laDistance;
        // option
        transform.LookAt(laCible.transform);
    }
}
