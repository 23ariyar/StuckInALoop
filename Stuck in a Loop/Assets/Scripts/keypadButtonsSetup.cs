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
    public Button buttonSix;
    public Button buttonSeven;
    public Button buttonEight;
    public Button buttonNine;





    public GameObject keypadPanel;
    public TaskManager taskManager;
    public GameObject borderPanel;

    
    

    bool keyOneHasBeenPressed = false, keyTwoHasBeenPressed = false;

    void Start()
    {
        buttonOne.onClick.AddListener(() => ButtonSequenceDetector("1"));
        buttonTwo.onClick.AddListener(() => ButtonSequenceDetector("2"));
        buttonThree.onClick.AddListener(() => ButtonSequenceDetector("3"));
        buttonFour.onClick.AddListener(() => ButtonSequenceDetector("4"));
        buttonFive.onClick.AddListener(() => ButtonSequenceDetector("5"));
        buttonSix.onClick.AddListener(() => ButtonSequenceDetector("6"));
        buttonSeven.onClick.AddListener(() => ButtonSequenceDetector("7"));
        buttonEight.onClick.AddListener(() => ButtonSequenceDetector("8"));
        buttonNine.onClick.AddListener(() => ButtonSequenceDetector("9"));


    }

    private void ButtonSequenceDetector(string key)
    {

        if (key == "9" || keyOneHasBeenPressed)
        {
            if (key == "9")
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
                        if (key == "7")
                        {
                            keypadPanel.SetActive(false);
                            borderPanel.SetActive(false);
                            
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


