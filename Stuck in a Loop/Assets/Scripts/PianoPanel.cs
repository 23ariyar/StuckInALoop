using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PianoPanel : MonoBehaviour
{
    public GameObject buttonC;
    public GameObject buttonD;
    public GameObject buttonE;
    public GameObject buttonF;
    public GameObject buttonG;
    public GameObject buttonA;
    public GameObject buttonB;
    public GameObject buttonCTwo;
    public GameObject buttonDTwo;
    public GameObject buttonETwo;





    public GameObject pianoPanel;
    public TaskManager taskManager;
    



    bool keyAHasBeenPressed = false, keyBHasBeenPressed = false;

    void Start()
    {

        buttonC.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("C"));
        buttonD.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("D"));
        buttonE.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("E"));
        buttonF.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("F"));
        buttonG.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("G"));
        buttonA.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("A"));
        buttonB.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("B"));
        buttonCTwo.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("C"));
        buttonDTwo.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("D"));
        buttonETwo.GetComponent<Button>().onClick.AddListener(() => KeySequenceDetector("E"));


    }

    private void KeySequenceDetector(string key)
    {
        

        if (key == "A" || keyAHasBeenPressed)
        {
            if (key == "A")
            {
                keyAHasBeenPressed = true;
                return;
            }
            else
            {
                if (key == "B" || keyBHasBeenPressed)
                {
                    if (key == "B")
                    {
                        keyBHasBeenPressed = true;
                        return;
                    }
                    else
                    {
                        if (key == "C")
                        {
                            pianoPanel.SetActive(false);
                            
                            taskManager.pianoCompleted();
                        }
                    }
                }
            }
        }
        keyAHasBeenPressed = false;
        keyBHasBeenPressed = false;
    }
}