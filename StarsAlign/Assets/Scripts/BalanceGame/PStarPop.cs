using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.InputSystem; 

public class PStarPop : MonoBehaviour
{
   public GameObject SmashEffect;
    

  public void popCurrentStar()
  {
    // Debug.Log("pop" ); 
     Destroy(gameObject); 
      Instantiate(SmashEffect, transform.position, Quaternion.identity); 
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
