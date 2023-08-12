using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OutroAnim : MonoBehaviour
{
  public Animator animator;
 void Update()
    {
        loadScene(); 
      
    }

    bool isPlaying() {
        if( animator.GetCurrentAnimatorStateInfo(0).IsName("OutroAnima") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) {
            return true; 
        } else {
            return false;
        }
             
    }

    void loadScene() {
        if(isPlaying() == false) {
            SceneManager.LoadScene("StartScreen");
        }
    }
}
