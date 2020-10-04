using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public bool constellationTask = false;

    void Update()
    {
        //Debug.Log(constellationTask.ToString());
    }

    public void constellationCompleted()
    {
        constellationTask = true;
    }

}
