using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHand : MonoBehaviour
{
    public Transform hourHandTransform;
    public GameObject clockPanel;
    public TaskManager taskManager;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            hourHandTransform.Rotate(new Vector3(0, 0, -30));
        }
        
    }

    public void Check()
    {
        
        if (hourHandTransform.rotation.eulerAngles.z - 90 < 0.001)
        {
            clockPanel.SetActive(false);
            taskManager.clockCompleted();
        } else
        {
            hourHandTransform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
}
