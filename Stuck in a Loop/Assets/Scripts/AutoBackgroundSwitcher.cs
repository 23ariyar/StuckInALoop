using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoBackgroundSwitcher : MonoBehaviour
{
    public Sprite backgroundOne;
    public Sprite backgroundTwo;
    public Sprite backgroundThree;
    public Sprite backgroundFour;
    public Sprite backgroundFive;
    public SpriteRenderer backgroundRenderer;
    public int backgroundIndex = 0;
    List<Sprite> backgrounds = new List<Sprite>(); //list of sprites

    public RoundReset resetScript;

    // Start is called before the first frame update
    void Start()
    {
        
        backgrounds.Add(backgroundOne); //adding ecah sprite to list
        backgrounds.Add(backgroundTwo);
        backgrounds.Add(backgroundThree);
        backgrounds.Add(backgroundFour);
        backgrounds.Add(backgroundFive);

        InvokeRepeating("SwitchBackground", 0.0f, 12.0f); //every 12 seconds switch background
        
    }

    // Update is called once per frame
    public void SwitchBackground()
    {
        if (backgroundIndex + 1 < 5) { //if there's still more to go
            backgroundIndex += 1;
            backgroundRenderer.sprite = backgrounds[backgroundIndex];
        } else //otherwise reset the background and call the resetall function in the resetscript
        {
            backgroundIndex = 0;
            backgroundRenderer.sprite = backgroundOne;
            resetScript.ResetAll();
        }
    }
}
