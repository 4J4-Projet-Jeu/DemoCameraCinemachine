using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCinemachine : MonoBehaviour
{
    // Tableau different de ceux de JS
    // le nombre d'élément sera déterminé dans l'inspecteur
    // mais les variables doivent être publiques
    public GameObject[] lesCameras;
    public float[] mesChiffres;

    

    void Start()
    {
        ActiveCam(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActiveCam(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActiveCam(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActiveCam(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ActiveCam(3);
        }
    }

    void ActiveCam (int indexCamActive)
    {
        foreach (GameObject laCam in lesCameras)
        {
            laCam.SetActive(false);
        }
        lesCameras[indexCamActive].SetActive(true);
    }
}
