using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStarPop : MonoBehaviour
{
   public GameObject smashEffect;
    

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
      Instantiate(smashEffect, transform.position, Quaternion.identity); 
      // StartCoroutine(destroyAnimation()); 
    }

    // IEnumerator destroyAnimation() {
    //   Debug.Log("destroy animation"); 
    //   yield return new WaitForSeconds(.02f); 
    //   Destroy(); 
    // }

    // public void destroyStar() {
    //   // if(gameObject != null) {
    //   //     Destroy(gameObject); 
    //   // }
    //   Debug.Log(gameObject); 
    // }
}
