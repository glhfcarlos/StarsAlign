using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundPlayer : MonoBehaviour
{
    public Button yourButton; // Reference to your button in the scene
    public AudioSource audioSource; // Reference to the AudioSource component

    private bool isPlaying = false;

    private void Start()
    {
        // Register a listener for the button's onClick event
        yourButton.onClick.AddListener(PlaySoundOnClick);
    }

    private void PlaySoundOnClick()
    {
        // If audioSource is not null and is not currently playing, play the sound
        if (audioSource != null && !isPlaying)
        {
            StartCoroutine(PlaySoundCoroutine());
        }
    }

    private System.Collections.IEnumerator PlaySoundCoroutine()
    {
        isPlaying = true;
        audioSource.Play();

        // Wait until the sound finishes playing
        yield return new WaitForSeconds(audioSource.clip.length);

        // Reset the isPlaying flag after the sound has finished
        isPlaying = false;
    }
}




