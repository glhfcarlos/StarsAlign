using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour
{

    public GameObject Messagepopup;
    Animator owlanimation;


    private void Start()
    {
        owlanimation = gameObject.GetComponent<Animator>(); 
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")

        {
            Messagepopup.SetActive(true);
            owlanimation.enabled = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       if (other.gameObject.tag == "Player")
        {
            Messagepopup.SetActive(false);
            owlanimation.enabled = false;
        }
    }


}
