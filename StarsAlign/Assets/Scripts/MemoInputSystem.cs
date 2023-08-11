using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class MemoInputSystem : MonoBehaviour
{

    public MiniGame miniGame; 

    public void BtnY(InputAction.CallbackContext context) {
        // Debug.Log("Y btn clicked" + context.phase ); 
        if(context.performed) {
            Debug.Log("Y btn " + context.phase); 
            miniGame.ButtonClickOrder(0); 
        }
       
    }

    public void BtnX(InputAction.CallbackContext context) {
        if(context.performed) {
        Debug.Log("X btn" + context.phase); 
        miniGame.ButtonClickOrder(2); 
        }
    }

     public void BtnB(InputAction.CallbackContext context) {
        if(context.performed) {
        Debug.Log("B btn" + context.phase); 
        miniGame.ButtonClickOrder(1); 
        }
    }

      public void BtnA(InputAction.CallbackContext context) {
        if(context.performed) {
        Debug.Log("A btn " + context.phase); 
        miniGame.ButtonClickOrder(3); 
        }
    }
}
