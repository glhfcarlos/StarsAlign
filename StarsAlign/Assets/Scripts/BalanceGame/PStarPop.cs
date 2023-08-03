using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PStarPop : MonoBehaviour
{
   public GameObject SmashEffect;
    

private void OnPop() {
  Debug.Log("left Pressed " ); 
  OnMouseDown(); 
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
