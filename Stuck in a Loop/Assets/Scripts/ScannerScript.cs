using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScannerScript : MonoBehaviour
{
    public GameObject hitEObject; //gameObject for hit e to use text
    //private Vector3 teleportLocation =  new Vector3(-26.3f, 3.3f, 104f);
    public RoundReset roundReset;
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

            roundReset.resetPlayer();
            roundReset.resetCamera();

        }
    }



    void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player") //if colliding with player
        {
            hitEObject.SetActive(false);

        }
    }


}
