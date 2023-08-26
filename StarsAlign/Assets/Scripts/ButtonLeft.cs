using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeft : MonoBehaviour
{
  PlayerControlsOne controls; 
    public Animator anim; 
    public MiniGame miniGame; 
    public ButtonSoundPlayer sound; 


    void Awake() {
        controls = new PlayerControlsOne(); 
        controls.GamePlayerOne.Left.performed += ctx => Left();

    }

    void Update() {
        if(miniGame.disableBtn) {
            OnDisabled(); 
        } else {
            OnEnable(); 
        }
    }

    void Left() {
        sound.PlaySoundOnClick(); 
        anim.SetTrigger("Highlighted"); 
        anim.SetTrigger("Pressed"); 
        anim.SetTrigger("Selected"); 
        // anim.SetTrigger("Disabled"); 
        // OnDisabled(); 
        miniGame.ButtonClickOrder(2); 
    }

    void OnEnable() {
        controls.GamePlayerOne.Enable(); 
    
    }



    void OnDisabled() {

        controls.GamePlayerOne.Disable(); 
       
    }
}
