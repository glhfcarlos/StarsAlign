using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 
public class VirtualMouse : MonoBehaviour
{
    PStarPop currentStar = null;

     private void OnTriggerEnter2D(Collider2D other)
    {
        
        //Check to see if the tag on the collider is equal to Enemy
         if(other.tag == "pStar" || other.tag == "loverStar")
        {
            currentStar = other.GetComponent<PStarPop>();
            
        }
    }

     private void OnTriggerExit2D(Collider2D other)
    {
        
        if(other.tag == "pStar" || other.tag == "loverStar")
        {
            // Debug.Log("trigger by star"); 
            PStarPop star = other.GetComponent<PStarPop>();

            if (star == currentStar)
            {
                currentStar = null;
            }
        }
    }


    // public void PopCurrentStar()
    // {
    //     if (currentStar != null)
    //     {
    //         currentStar.OnPop();
    //     }
    // }

    public void Pop(InputAction.CallbackContext context)
    {
        // Debug.Log("Pressed the button"); 
        if(context.performed) {
            // Debug.Log("Pressed the button"); 
            currentStar.popCurrentStar();
        }
    }
}
