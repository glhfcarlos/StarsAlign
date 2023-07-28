using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStarPop : MonoBehaviour
{
   public GameObject SmashEffect;
    

    void Update() {
        if(Input.GetButtonDown("Xbox_LB")) {
          Debug.Log("Xbox Left Bumber button clicked"); 
        }

      if(Input.GetButton("Xbox_Y")) {
        Debug.Log("Xbox Y clicked"); 
      }

       if(Input.GetButtonDown("Xbox_A")) {
        Debug.Log("Xbox A clicked"); 
      }

    }

     void OnMouseDown()
    {
      // Debug.Log("Destroyed"); 
      Destroy(gameObject); 
      Instantiate(SmashEffect, transform.position, Quaternion.identity); 
    }

    // public void destroyStar() {
    //   // if(gameObject != null) {
    //   //     Destroy(gameObject); 
    //   // }
    //   Debug.Log(gameObject); 
    // }
}
