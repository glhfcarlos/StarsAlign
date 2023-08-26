using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDowm : MonoBehaviour
{
    PlayerControlsOne controls; 
    public Animator anim; 
    public MiniGame miniGame; 
    public ButtonSoundPlayer sound; 

    void Awake() {
        controls = new PlayerControlsOne(); 
        controls.GamePlayerOne.Down.performed += ctx => Down(); 
        // anim = GetComponent<Animator>(); 
    }

    void Update() {
        if(miniGame.disableBtn) {
            OnDisabled(); 
        } else {
            OnEnable(); 
        }
    }


    void Down() {
        sound.PlaySoundOnClick(); 
        anim.SetTrigger("Highlighted"); 
        anim.SetTrigger("Pressed"); 
        anim.SetTrigger("Selected"); 
        // anim.SetTrigger("Disabled"); 
        // OnDisabled(); 
        miniGame.ButtonClickOrder(3); 
    }

    void OnEnable() {
        controls.GamePlayerOne.Enable(); 
    
    }


    void OnDisabled() {

        controls.GamePlayerOne.Disable(); 
       
    }
}
