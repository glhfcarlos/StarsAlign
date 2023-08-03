using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingImageSoundPlayer : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = audioClip;
    }

    public void PlayFlashingImageSound()
    {
        if (audioClip != null)
        {
            audioSource.Play();
        }
    }
}

