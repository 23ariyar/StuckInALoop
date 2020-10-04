using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public bool constellationTask = false;

    public GameObject taskComplete; 
    void Update()
    {
        //Debug.Log(constellationTask.ToString());
    }

    public void constellationCompleted()
    {
        constellationTask = true;
        taskComplete.SetActive(true);
        Invoke("taskCompleteSetInactive", 2f);
    }


    public void taskCompleteSetInactive()
    {
        taskComplete.SetActive(false);
    }

}
