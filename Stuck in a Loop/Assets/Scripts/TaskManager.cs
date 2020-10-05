using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    private bool constellationTask = false;
    //private bool keypadOpener = false;
    private bool clockTask = false;
    private bool pianoTask = false;



    public int TOTAL_TASKS;
    public int completedTasks;
    public Text tasksDisplayUI;

    public GameObject taskComplete; 
    void Start()
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
        //keypadOpener = true;
    }

    public void pianoCompleted()
    {
        taskComplete.SetActive(true);
        Invoke("taskCompleteSetInactive", 2f);
        addTasks(pianoTask);
        pianoTask = true;

    }




    public void clockCompleted()
    {
        taskComplete.SetActive(true);
        Invoke("taskCompleteSetInactive", 2f);
        addTasks(clockTask);
        clockTask = true;
    }


    public void taskCompleteSetInactive()
    {
        taskComplete.SetActive(false);
       
    }

    public void addTasks(bool taskCompeletedBool, int completed = 1)
    {
        Debug.Log("Here");
        if (taskCompeletedBool == false )
        {
            completedTasks += 1;
            tasksDisplayUI.text = "KEYS: " + completedTasks + " / " + TOTAL_TASKS;
           
        }
        
    }
}
