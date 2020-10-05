using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeypadUser : MonoBehaviour
{
    public GameObject hitEObject; //gameObject for hit e to use text
    public SpriteRenderer imageRenderer;
    public Sprite highlightedImage;
    public Sprite normalImage;
    public GameObject keypadPanel;


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
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            keypadPanel.SetActive(true);

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player") //if colliding with player
        {
            hitEObject.SetActive(false);
            imageRenderer.sprite = normalImage;
            keypadPanel.SetActive(false);
        }
    }


}
