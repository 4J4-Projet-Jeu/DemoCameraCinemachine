using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteControle : MonoBehaviour
{
    public bool PeutOuvrir;

    [SerializeField]
    AudioClip sonOuvrir;
    [SerializeField]
    AudioClip sonRefus;
    [SerializeField]
    GameObject murFeu;


    private AudioSource laSourceAudio;

    private void Start()
    {
        laSourceAudio = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider infoPorte)
    {
       

       if(infoPorte.tag == "Player"  && PeutOuvrir)
       {

            GameObject.Find("Porte").GetComponent<Animator>().enabled = true;
            laSourceAudio.PlayOneShot(sonOuvrir);
            murFeu.SetActive(true);
       
        }
        else
        {
            
            laSourceAudio.PlayOneShot(sonRefus);
        }
       
        
    }
}
