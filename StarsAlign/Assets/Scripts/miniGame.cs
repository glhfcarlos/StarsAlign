using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGame : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;// holds all the buttons getting pressed 
    [SerializeField] int[] lightOrder; // the game pannel that opens and closes 
    // [SerializeField] GameObject miniGamePanel; // start button to open the level
    [SerializeField] GameObject[] lightsArray; // lights on left pannel that blinks for user to copy 
    int level = 0; // level of player is currently on
    int buttonsclicked = 0; // tracks which buttons been clicked 
    int colorOrderRunCount = 0; // run count of color 
    bool passed = false; 
    bool won = false;
    Color32 red = new Color32(255, 39, 0, 255); // decalared color we want 
    Color32 green = new Color32(4, 204, 0, 255);
    Color32 invisible = new Color32(4, 204, 0, 0);
    Color32 white = new Color32(255, 255, 255, 255);
    public float lightspeed; // so you can change the light order since light order was set to 1/2 sec


    void OnEnable() // get called everytime the pannel get enabled // a placed when we want to reset the game and start fresh  
    {
        Debug.Log("enable being called");
        level = 0; // we set everthing to zero because method gets called when restart 
        buttonsclicked = 0;
        colorOrderRunCount = -1;
        won = false;
        for (int i = 0; i < lightOrder.Length; i++) // this loop gives us a random order of lights 
        {
            lightOrder[i] = Random.Range(0, 3); // this gives us our new light order 
        }
        level = 1; // since this methods gets called after the level starts at one 
        StartCoroutine(ColorOrder());
    }

    public void ButtonClickOrder(int button) // this is to check if we are click the correct pattern  
    {
        buttonsclicked++;
        if (button == lightOrder[buttonsclicked - 1]) // if the button number is the equal to the light order 
        {
            Debug.Log("pass"); // then you pass
            passed = true;
        }
        else
        {
            Debug.Log("failed"); // else you failed 
            won = false;
            passed = false;
            StartCoroutine(ColorBlink(red));// this calls the fucntion for it to blink red for the user to know they failed 
        }
        if (buttonsclicked == level && passed == true && buttonsclicked != 5)
        {
            level++; // added to level 
            passed = false; // resets that level to not passed 
            StartCoroutine(ColorOrder()); // shows the next list of colors to play
        }
        if (buttonsclicked == level && passed == true && buttonsclicked == 5) // if true you win the game 
        {
            Debug.Log("failed");
            won = true; 
            StartCoroutine(ColorBlink(green));
        }
    }

    

    IEnumerator ColorBlink(Color32 colorToBlink) // when this being called it blinks three times in red 
    {
        DisableInteractableButtons();
        for (int j = 0; j < 3; j++) // run three times for the three blinks of red
        {
            Debug.Log("RUN " + j);
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Image>().color = colorToBlink;
            }
            yield return new WaitForSeconds(0.5f); // timer for give it second to make it feel natural 
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<Image>().color = white;
            }
            yield return new WaitForSeconds(0.5f);
        }
        if (won == true)
        {
            Debug.Log("won stuffs aqui");
            
        }
        EnableInteractableButtons();
        OnEnable();
    }

    IEnumerator ColorOrder() // 
    {
        Debug.Log("Color Order should falsh from being called"); 
        buttonsclicked = 0; // if clicked 
        colorOrderRunCount++;
        DisableInteractableButtons(); //disables the interactible buttons 
        for (int i = 0; i <= colorOrderRunCount; i++) // this loops gives us the run order of each round 
        { // for loop is skipped on first play 
            if (level >= colorOrderRunCount)
            {
                lightsArray[lightOrder[i]].GetComponent<Image>().color = invisible;
                yield return new WaitForSeconds(lightspeed);
                lightsArray[lightOrder[i]].GetComponent<Image>().color = green;
                yield return new WaitForSeconds(lightspeed);
                lightsArray[lightOrder[i]].GetComponent<Image>().color = invisible;
            }
        }
        EnableInteractableButtons();
        Debug.Log("End of ColorOder method");
    }

    void DisableInteractableButtons() // this is what disabled all the buttons from being pressed 
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Button>().interactable = false;
        }
    }

    void EnableInteractableButtons() // this disables button back on to be interactive 
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<Button>().interactable = true;
        }
    }
}