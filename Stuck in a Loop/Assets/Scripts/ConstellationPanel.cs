using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class ConstellationPanel : MonoBehaviour
{
    
    public GameObject hitEObject; //gameObject for hit e to use text
    public SpriteRenderer imageRenderer;
    public Sprite highlightedImage;
    public Sprite normalImage;
    public GameObject constellationPanel;
    public RotateClockwise rotateClockwiseScript;


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
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            
            constellationPanel.SetActive(true);
            hitEObject.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player") //if player was the object that left
        {
            hitEObject.SetActive(false);
            imageRenderer.sprite = normalImage;
            constellationPanel.SetActive(false);
            rotateClockwiseScript.resetConstellations();


        }
    }

    
}
