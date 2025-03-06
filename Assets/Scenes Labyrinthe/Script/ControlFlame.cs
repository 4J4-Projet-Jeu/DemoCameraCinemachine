using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlFlame : MonoBehaviour
{
   [SerializeField]
    int prochainNiveau;
   [SerializeField]
    bool autoIndex = true;

    private void Start()
    {
        if (autoIndex)
        {
            prochainNiveau = SceneManager.GetActiveScene().buildIndex + 1;
        }
        
    }

    private void OnCollisionEnter(Collision infoObjet)
    {
        if (infoObjet.collider.tag == "Player")
        {
            PlayerPrefs.SetInt("prochainNiveau", prochainNiveau);

            // Afin d'aller chercher la scène suivante par son index
            SceneManager.LoadScene(prochainNiveau);

        }
    }
}
