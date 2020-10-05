using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConstellationHintUser : MonoBehaviour
{
    public GameObject hitEObject; //gameObject for hit e to use text

    public GameObject constellationHintPanel;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //if colliding with player
        {
            hitEObject.SetActive(true);


        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) //if colliding with player
        {
            constellationHintPanel.SetActive(true);
            

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player") //if colliding with player
        {
            hitEObject.SetActive(false);
            constellationHintPanel.SetActive(false);

        }
    }


}
