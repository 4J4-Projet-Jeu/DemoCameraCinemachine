using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSuiviFluide : MonoBehaviour
{
    public GameObject laCible;
    public Vector3 laDistance;
    public float amortissement;

 
    // Update is called once per frame
    void FixedUpdate()
    {
        // TransformPoint prend la position de l'hélico en ajoutant la distance
        // Ça transforme le résultat en unité dans le monde plutôt que unité locale
        Vector3 positionFinale = laCible.transform.TransformPoint(laDistance);

        //Vector3 positionFinaleLocal = laCible.transform.position + laDistance;

        //print("Ori : " + positionFinale.x + "_" + positionFinale.y + "_" + positionFinale.z + "\n");
        //print("test : " + positionFinaleLocal.x + "_" + positionFinaleLocal.y + "_" + positionFinaleLocal.z + "\n");

        // maintenant on change la position de la caméra
        transform.position = Vector3.Lerp(transform.position, positionFinale, amortissement);
        // Lerp = interpolation mais dans le code
        // donc une interpolation entre la position de la caméra et la position désirée
        // amortissement entre 0 et 1 comme un pourcentage (scale ou autre)

        transform.LookAt(laCible.transform);

    }
}
