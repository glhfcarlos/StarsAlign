using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    public string SceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
