using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    public string SceneName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.GetComponent<PlayerMovement>() != null)
        {
            SceneManager.LoadScene(SceneName);
        }
    }

    public void OnButtonPressed()
    {
        SceneManager.LoadScene(SceneName);
    }
}
