using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad; // The name of the scene to load

    private void OnTriggerEnter2D(Collider2D collision)
    {       Debug.Log("PreLoad");
        if (collision.gameObject.CompareTag("SceneTransitionTag"))
        {
            Debug.Log("LOAD");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}


