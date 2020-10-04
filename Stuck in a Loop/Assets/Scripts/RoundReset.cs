using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundReset : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    public Vector3 cameraResetPos;

    public void ResetAll()
    {
        resetPlayer();
        resetCamera();
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
}
