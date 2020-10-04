using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class FXSource : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayButtonSounds()
    {
        
        audioSource.Play();
    }
}
