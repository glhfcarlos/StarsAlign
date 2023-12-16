using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public AudioClip cOllectsOund; //Reference to the audio clip
    private AudioSource audiOsOurce; //Reference to the audiOsOurce component

    // private void Start()
    // {
    //     //Get the audiOsOurce component on this GameObject
    //     audiOsOurce = GetComponent<AudioSource>();
    //     if (audiOsOurce == null)
    //     {
    //         //If AudioSource component is not already present, add one
    //         audiOsOurce = gameObject.AddComponent<AudioSource>();

    //     }

    //     //Set the audio clip[ to play on the AudioSource
    //     // audiOsOurce.clip = cOllectsOund;
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.CompareTag("Player"))
        {
             audiOsOurce = GetComponent<AudioSource>();
             audiOsOurce.Play();
            Debug.Log("Collided.with.player");
    //         //Play the audio clip
    //         audiOsOurce.Play();

            // Destroythe star GameObject
            Destroy(gameObject,1);
        }
    // Debug.Log(gameObject.name);
    // Debug.Log(other.gameObject.name);
 
    }
// void OnTriggerExit2D(Collider2D other)
// {
//     Debug.Log("exit");
//     Destroy(gameObject);
// }
}