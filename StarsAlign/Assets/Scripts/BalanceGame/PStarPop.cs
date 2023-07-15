using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStarPop : MonoBehaviour
{
   // public GameObject SmashEffect;
    

     void OnMouseDown()
    {
      Debug.Log("Destroyed"); 
      Destroy(gameObject); 
    //   Instantiate(SmashEffect, transform.position, Quaternion.identity); 
    }

    // public void destroyStar() {
    //   // if(gameObject != null) {
    //   //     Destroy(gameObject); 
    //   // }
    //   Debug.Log(gameObject); 
    // }
}
