using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decompte : MonoBehaviour
{
    [SerializeField]
    int departCompteur = 300;
    [SerializeField]
    Text txtCompteur;

    void Start()
    {

        txtCompteur.text = "Compteur : " + departCompteur;
        StartCoroutine(LeCompteur());
    }


    IEnumerator LeCompteur()
    {
        while(departCompteur > 0) {

            yield return new WaitForSeconds(1f);
            departCompteur--;
            txtCompteur.text = "Compteur : " + departCompteur;
        }

        //Debug.Log("vous êtes mort");
        GameObject.Find("Personnage").GetComponent<ControleurPersonnage>().PartieTerminee();

    }
}
