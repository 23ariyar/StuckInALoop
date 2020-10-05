using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    private bool constellationTask = false;
    private bool keypadOpener = false;
    public int TOTAL_TASKS;
    private int completedTasks;
    public Text tasksDisplayUI;

    public GameObject taskComplete; 
    void Update()
    {
        tasksDisplayUI.text = "KEYS: 0" + " / " + TOTAL_TASKS;
    }

    public void constellationCompleted()
    {
        
        taskComplete.SetActive(true);
        Invoke("taskCompleteSetInactive", 2f);
        addTasks(constellationTask);
        constellationTask = true;
    }

    public void keypadCompleted()
    {
        taskComplete.SetActive(true);
        Invoke("taskCompleteSetInactive", 2f);
        keypadOpener = true;
    }


    public void taskCompleteSetInactive()
    {
        taskComplete.SetActive(false);
    }

    public void addTasks(bool taskCompeletedBool, int completed = 1)
    {
        if (taskCompeletedBool == false )
        {
            completedTasks += completed;
            tasksDisplayUI.text = "KEYS: " + completedTasks + " / " + TOTAL_TASKS;
           
        }
        
    }
}
