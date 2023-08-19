using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class starbutton : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public void OnButtonPressed()
    {
        PlayerCheckPointSystem.ResetCheckpointPosition(); // Reset checkpoints here

        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene("IntroAnim");
    }
}


