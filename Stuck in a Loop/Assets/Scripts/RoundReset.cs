using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundReset : MonoBehaviour
{
    public GameObject player;

    public void ResetAll()
    {
        resetPlayer();
    }
    public void ResetBackground()
    {
        //background image resets on its own
    }

    public void resetPlayer()
    {
        player.transform.position = new Vector3(103f, 61f, 90f);
    }
}
