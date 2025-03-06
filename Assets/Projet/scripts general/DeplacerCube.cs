using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeplacerCube : MonoBehaviour
{

    public float vitesseAvance;
    public float vitesseTourne;

    public TextMeshProUGUI affichageInfo;

    float compteurDeFrame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //compteurDeFrame++;

        //affichageInfo.text = compteurDeFrame.ToString();

        //Input.GetAxisRaw("Vertical"); // valeur possible de -1, 0 ou 1

        float valeurAxeVertical = Input.GetAxis("Vertical"); // valeur entre -1 et 1 
        float valeurAxeHorizontal = Input.GetAxis("Horizontal");// 0 étant la touche non touchée

        affichageInfo.text = valeurAxeVertical.ToString();

        transform.Translate(0f, 0f, valeurAxeVertical * vitesseAvance * Time.deltaTime, Space.Self);
        transform.Rotate(0f, valeurAxeHorizontal * vitesseTourne * Time.deltaTime, 0f, Space.World);
    }
}
