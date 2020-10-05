using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PillarUser : MonoBehaviour
{
    public GameObject hitEObject; //gameObject for hit e to use text
    public SpriteRenderer imageRenderer;
    public Sprite highlightedImage;
    public Sprite normalImage;
    public TaskManager taskManager;
    public GameObject textPanel;
    public TextMeshProUGUI m_Text;


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
            if (taskManager.completedTasks != taskManager.TOTAL_TASKS)
            {
                textPanel.SetActive(true);
                m_Text.text = "You need 3 keys to enter";
                Invoke("turnOffTextUI", 2f);
            } else
            {
                textPanel.SetActive(true);
                m_Text.text = "You win!";
                Invoke("turnOffTextUI", 2f);
            }

        }
    }

    private void turnOffTextUI()
    {
        textPanel.SetActive(false);
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player") //if colliding with player
        {
            hitEObject.SetActive(false);
            imageRenderer.sprite = normalImage;
        }
    }

}
