using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memogamebutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void button_touch()
    {
        GetComponent<Animation>().Play("buttonpressed");
    }

    
}
