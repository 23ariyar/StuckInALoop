using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public void SetResolution1600x900()
    {
        Debug.Log("Res set!");
        Screen.SetResolution(1600, 900, true);
    }
    public void SetResolution1920x1080()
    {
        Debug.Log("Res set!");
        Screen.SetResolution(1920, 1080, true);
    }
}
