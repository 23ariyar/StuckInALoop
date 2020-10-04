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
    List<Sprite> backgrounds = new List<Sprite>();

    public RoundReset resetScript;

    // Start is called before the first frame update
    void Start()
    {
        
        backgrounds.Add(backgroundOne);
        backgrounds.Add(backgroundTwo);
        backgrounds.Add(backgroundThree);
        backgrounds.Add(backgroundFour);
        backgrounds.Add(backgroundFive);

        InvokeRepeating("SwitchBackground", 0.0f, 12.0f);
        
    }

    // Update is called once per frame
    public void SwitchBackground()
    {
        if (backgroundIndex + 1 < 5) {
            backgroundIndex += 1;
            backgroundRenderer.sprite = backgrounds[backgroundIndex];
        } else
        {
            backgroundIndex = 0;
            backgroundRenderer.sprite = backgroundOne;
            resetScript.ResetAll();
        }
    }
}
