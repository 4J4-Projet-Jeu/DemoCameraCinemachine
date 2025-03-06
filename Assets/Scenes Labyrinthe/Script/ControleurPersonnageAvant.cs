using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleurPersonnageAvant : MonoBehaviour
{

    [SerializeField] float vitesse = 4f, vitesseActuelle;

    // On créer une occurence avec les valeurs à null
    Vector3 deplacement =  Vector3.zero;


    
    void Start()
    {
        
    }

    // Update crée un espèce de vibration lors des collisions, donc on utilise un FixedUpdate:
    //void Update()
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            deplacement = Vector3.zero;
            transform.Rotate(Vector3.up * -vitesseActuelle * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            deplacement = Vector3.zero;
            transform.Rotate(Vector3.up * vitesseActuelle * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            deplacement = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            deplacement = Vector3.back;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            
            vitesseActuelle = vitesse * 10;

        }
        else
        {
            vitesseActuelle = vitesse;
        }
        

        //Time.deltaTime sert à uniformiser le calcul selon les processeurs
        // Comme on utilise le FixedUpdate...  fixedDeltaTime
        transform.Translate(deplacement * vitesseActuelle *  Time.fixedDeltaTime /*Time.deltaTime*/);
        deplacement = Vector3.zero;
    }
}
