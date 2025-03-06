using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleurPersonnage : MonoBehaviour
{

    [SerializeField]
    float vitesse = 4f, rotationPerso = 80f, vitesseActuelle;
    [SerializeField]
    GameObject ImgPartieTerminee;



    void Start()
    {
        
    }

    // Update crée un espèce de vibration lors des collisions, donc on utilise un FixedUpdate:
    //void Update()
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            
            vitesseActuelle = vitesse * 10;

        }
        else
        {
            vitesseActuelle = vitesse;
        }

        transform.Rotate(Vector3.up * rotationPerso * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));

        float antiRecul = Input.GetAxis("Vertical");

        if (antiRecul > 0)
        {
            transform.Translate(Vector3.forward * vitesseActuelle * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        }

    }

    public void PartieTerminee()
    {

        ImgPartieTerminee.SetActive(true);
        StartCoroutine(TelechargerMenu());

    }

    IEnumerator TelechargerMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }
}
