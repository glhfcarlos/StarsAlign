using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameOne : MonoBehaviour
{
    PlayerControlsOne controls; 
    public Animator anim; 
    public MiniGame miniGame; 

    void Awake() {
        controls = new PlayerControlsOne(); 
        controls.GamePlayerOne.Up.performed += ctx => Up(); 


        // anim = GetComponent<Animator>(); 
    }

    void Update() {
        if(miniGame.disableBtn) {
            OnDisabled(); 
        } else {
            OnEnable(); 
        }
    }

    void Up() {
        Debug.Log("Up pressed"); 
        anim.SetTrigger("Highlighted"); 
        anim.SetTrigger("Pressed"); 
        anim.SetTrigger("Selected"); 
        // anim.SetTrigger("Disabled"); 
        // OnDisabled(); 
        miniGame.ButtonClickOrder(0); 
    }
    void OnEnable() {
        controls.GamePlayerOne.Enable(); 
    
    }



    void OnDisabled() {

        controls.GamePlayerOne.Disable(); 
       
    }
}
