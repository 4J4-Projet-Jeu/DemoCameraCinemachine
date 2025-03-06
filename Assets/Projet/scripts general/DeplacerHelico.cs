using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeplacerHelico : MonoBehaviour
{
  
    public float vitesseTourne;
    public float vitesseMonte;

    public float vitesseAvant; // deviendra private eventuellement
    public float vitesseAvantMax;
    public float forceAcceleration;

    public GameObject refHeliceAvant;

    private Rigidbody rigidHelico;


    public TextMeshProUGUI affichageInfo;


    // Start is called before the first frame update
    void Start()
    {
        rigidHelico = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (refHeliceAvant.GetComponent<TournerHelices>().moteurEnMarche)
        {

            rigidHelico.useGravity = false;

            float forceRotation = Input.GetAxis("Horizontal") * vitesseTourne;
            float forceMonte = Input.GetAxis("Vertical") * vitesseMonte;

            GetComponent<Rigidbody>().AddRelativeTorque(0f, forceRotation, 0f);

            //GetComponent<Rigidbody>().AddRelativeForce(0f, forceMonte, 0f);

            if (Input.GetKey(KeyCode.E) && vitesseAvant < vitesseAvantMax) // accelerer
            {
                vitesseAvant += forceAcceleration;

            }

            if (Input.GetKey(KeyCode.Q) && vitesseAvant > 0f)  // il ne peut pas reculer
            {

                vitesseAvant -= forceAcceleration;
            }

            // ceci est une erreur, on ne peut appliquer 2 forces dans le même Update
            //GetComponent<Rigidbody>().AddRelativeForce(0f, 0f, vitesseAvant);

            //donc on met le addRelativeForce plus haut sera en commentaire
            GetComponent<Rigidbody>().AddRelativeForce(0f, forceMonte, vitesseAvant);

            affichageInfo.text = vitesseAvant.ToString();

            //correction au niveau de la rotation x et z
            transform.localEulerAngles = new Vector3(0f, transform.localEulerAngles.y, 0f);

        }
        else
        {
            rigidHelico.useGravity = true;
        }

    }
}
