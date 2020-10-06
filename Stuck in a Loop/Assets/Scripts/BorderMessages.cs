using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BorderMessages : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject textToChange;
    public string Message;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //if colliding with player
        {
            textPanel.SetActive(true);

            TextMeshProUGUI m_Text = textToChange.GetComponent<TextMeshProUGUI>();
            m_Text.SetText(Message);

        }
    }

    

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player") //if player was the object that left
        {
            textPanel.SetActive(false);
           
        }
    }

}
