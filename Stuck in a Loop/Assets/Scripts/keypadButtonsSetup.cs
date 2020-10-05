using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keypadButtonsSetup : MonoBehaviour
{
    public Button buttonOne;
    public Button buttonTwo;
    public Button buttonThree;
    public Button buttonFour;
    public Button buttonFive;
    public GameObject keypadPanel;
    public TaskManager taskManager;
    public GameObject triggerBorder;
    public GameObject noTriggerBorder;
    
    

    bool keyOneHasBeenPressed = false, keyTwoHasBeenPressed = false;

    void Start()
    {
        buttonOne.onClick.AddListener(() => ButtonSequenceDetector("1"));
        buttonTwo.onClick.AddListener(() => ButtonSequenceDetector("2"));
        buttonThree.onClick.AddListener(() => ButtonSequenceDetector("3"));
        buttonFour.onClick.AddListener(() => ButtonSequenceDetector("4"));
        buttonFive.onClick.AddListener(() => ButtonSequenceDetector("5"));

    }

    private void ButtonSequenceDetector(string key)
    {

        if (key == "1" || keyOneHasBeenPressed)
        {
            if (key == "1")
            {
                keyOneHasBeenPressed = true;
                return;
            }
            else
            {
                if (key == "2" || keyTwoHasBeenPressed)
                {
                    if (key == "2")
                    {
                        keyTwoHasBeenPressed = true;
                        return;
                    }
                    else
                    {
                        if (key == "3")
                        {
                            keypadPanel.SetActive(false);
                            noTriggerBorder.SetActive(false);
                            triggerBorder.SetActive(false);
                            taskManager.keypadCompleted();
                        }
                    }
                }
            }
        }
        keyOneHasBeenPressed = false;
        keyTwoHasBeenPressed = false;
    }
}


