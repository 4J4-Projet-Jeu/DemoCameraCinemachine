using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleControle : MonoBehaviour
{

    private void OnCollisionEnter(Collision infoObjet)
    {
        if (infoObjet.collider.tag == "Player")
        {
            // le Find() permet de chercher un gameObject dans la hyerarchie
            GameObject.Find("PorteVide").GetComponent<PorteControle>().PeutOuvrir = true;
            //GameObject.Find("Porte").GetComponent<BoxCollider>().isTrigger = true;
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = GetComponent<BoxCollider>().enabled = false;
            Destroy(transform.parent.gameObject, 3f);
        }
    }

}
