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

    private int roundsCompleted = 0;

    public void ResetAll()
    {
        roundsCompleted++;
        roundsDisplayUI.text = "ROUNDS: " + roundsCompleted;
        resetPlayer();
        //resetCamera();
        displayRoundLooped();
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

    public void displayRoundLooped()
    {
        roundLoopedImage.SetActive(true);
        Invoke("turnOffText", 2.5f);
    }

    public void turnOffText()
    {
        roundLoopedImage.SetActive(false);
    }
}
