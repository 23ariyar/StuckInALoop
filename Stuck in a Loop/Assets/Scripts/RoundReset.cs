using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundReset : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    public Vector3 cameraResetPos;
    public GameObject roundLoopedImage;
    public Text roundsDisplayUI;
    public AudioSource audioSource;

    public Sprite backgroundOne;
    public Sprite backgroundTwo;
    public Sprite backgroundThree;
    public Sprite backgroundFour;
    public Sprite backgroundFive;

    public SpriteRenderer backgroundRendererOne;
    public SpriteRenderer backgroundRendererTwo;
    public SpriteRenderer backgroundRendererThree;


    private int backgroundIndex = 0;
    List<Sprite> backgrounds = new List<Sprite>(); //list of sprites

    private int roundsCompleted = 0;

    void Start()
    {

        backgrounds.Add(backgroundOne); //adding ecah sprite to list
        backgrounds.Add(backgroundTwo);
        backgrounds.Add(backgroundThree);
        backgrounds.Add(backgroundFour);
        backgrounds.Add(backgroundFive);

        InvokeRepeating("SwitchBackground", 0.0f, 12.0f); //every 12 seconds switch background

    }

    public void ResetAll()
    {
        roundsCompleted++;
        roundsDisplayUI.text = "ROUNDS: " + roundsCompleted;
        resetPlayer();
        //resetCamera();
        displayRoundLooped();
        resetAudio();
    }
    public void ResetBackground()
    {
        //background image resets on its own
    }

    public void resetPlayer()
    {
        player.transform.position = new Vector3(103f, 56f, 90f);
        player.SetActive(true);
    }

    public void resetCamera()
    {
        mainCamera.transform.position = cameraResetPos;
    }

    public void resetAudio()
    {
        audioSource.Stop();
        audioSource.Play();
        
    }

    public void displayRoundLooped()
    {
        roundLoopedImage.SetActive(true);
        Invoke("turnOffText", 2.5f);
    }

    public void turnOffText()
    {
        roundLoopedImage.SetActive(false);
    }

    public void SwitchBackground()
    {

        if (backgroundIndex + 1 < 5)
        { //if there's still more to go
            backgroundIndex += 1;
            backgroundRendererOne.sprite = backgrounds[backgroundIndex];
            backgroundRendererTwo.sprite = backgrounds[backgroundIndex];
            backgroundRendererThree.sprite = backgrounds[backgroundIndex];
        }
        else //otherwise reset the background and call the resetall function in the resetscript
        {
            backgroundIndex = 0;
            backgroundRendererOne.sprite = backgrounds[backgroundIndex];
            backgroundRendererTwo.sprite = backgrounds[backgroundIndex];
            backgroundRendererThree.sprite = backgrounds[backgroundIndex];
            ResetAll();
        }
    }

}
