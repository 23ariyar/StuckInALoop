using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUser : MonoBehaviour
{
    public GameObject hitEObject; //gameObject for hit e to use text
    public SpriteRenderer imageRenderer;
    public Sprite highlightedImage;
    public Sprite normalImage;
    public GameObject clockPanel;
    public Transform hourHandTransform;

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
            clockPanel.SetActive(true);
            hitEObject.SetActive(false);

        }
    }


    void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player") //if colliding with player
        {
            hitEObject.SetActive(false);
            imageRenderer.sprite = normalImage;
            clockPanel.SetActive(false);
            hourHandTransform.eulerAngles.Set(0f, 0f, 0f);
        }
    }


}
