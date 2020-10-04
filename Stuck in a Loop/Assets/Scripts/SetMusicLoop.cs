using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetMusicLoop : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        gameObject.GetComponent<AudioSource>().loop = true;
    }

    // Update is called once per frame
    
}
