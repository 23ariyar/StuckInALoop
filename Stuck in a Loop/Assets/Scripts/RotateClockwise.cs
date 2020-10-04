using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateClockwise : MonoBehaviour
{
    public GameObject buttonOne;
    public GameObject buttonTwo;
    public GameObject buttonThree;
    public GameObject buttonFour;
    public Button checkButton;
    public GameObject constellationPanel;

    public Sprite constellationOneComplete;
    public Sprite constellationTwoComplete;
    public Sprite constellationThreeComplete;
    public Sprite constellationFourComplete;

    public Sprite constellationOne;
    public Sprite constellationTwo;
    public Sprite constellationThree;
    public Sprite constellationFour;

    //script for task manager
    public TaskManager taskScript;
    public void Start()
    {
        buttonOne.GetComponent<Button>().onClick.AddListener(() => Rotate(buttonOne.GetComponent<RectTransform>()));
        buttonTwo.GetComponent<Button>().onClick.AddListener(() => Rotate(buttonTwo.GetComponent<RectTransform>()));
        buttonThree.GetComponent<Button>().onClick.AddListener(() => Rotate(buttonThree.GetComponent<RectTransform>()));
        buttonFour.GetComponent<Button>().onClick.AddListener(() => Rotate(buttonFour.GetComponent<RectTransform>()));
        checkButton.onClick.AddListener(() => Check());
    }


    public void Rotate(RectTransform buttonTransform)
    {
       
        buttonTransform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
       


    }

    public void Check()
    {
        buttonOne.GetComponent<Image>().sprite = constellationTwoComplete;
        buttonTwo.GetComponent<Image>().sprite = constellationTwoComplete;
        buttonThree.GetComponent<Image>().sprite = constellationThreeComplete;
        buttonFour.GetComponent<Image>().sprite = constellationFourComplete;
        Invoke("switchToNormal", 2.0f);
    }

    public void switchToNormal()
    {
        
        buttonOne.GetComponent<Image>().sprite = constellationTwoComplete;
        buttonTwo.GetComponent<Image>().sprite = constellationTwo;
        buttonThree.GetComponent<Image>().sprite = constellationThree;
        buttonFour.GetComponent<Image>().sprite = constellationFour;
        //Debug.Log((buttonOne.GetComponent<RectTransform>().eulerAngles.z == 180 && buttonTwo.GetComponent<RectTransform>().eulerAngles.z == 90 && buttonThree.GetComponent<RectTransform>().eulerAngles.z == 180 && buttonFour.GetComponent<RectTransform>().eulerAngles.z == 0).ToString());
        if (buttonOne.GetComponent<RectTransform>().eulerAngles.z == 180 && buttonTwo.GetComponent<RectTransform>().eulerAngles.z == 90 && buttonThree.GetComponent<RectTransform>().eulerAngles.z == 180 && buttonFour.GetComponent<RectTransform>().eulerAngles.z == 0)
        {

            taskScript.constellationCompleted();
            constellationPanel.SetActive(false);
            //task completed

        }



    }

}
