using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class DisplayText : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject textToChange;
    public string Message;
    public GameObject hitEObject; //gameObject for hit e to use text
    public SpriteRenderer imageRenderer;
    public Sprite highlightedImage;
    public Sprite normalImage;
    

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //if colliding with player
        {
            hitEObject.SetActive(true);
            imageRenderer.sprite = highlightedImage;

        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) //if colliding with player
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
            hitEObject.SetActive(false);
            imageRenderer.sprite = normalImage;
        }
    }
}
