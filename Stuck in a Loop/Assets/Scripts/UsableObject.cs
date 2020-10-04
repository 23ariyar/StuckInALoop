using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsableObject : MonoBehaviour
{
    public GameObject hitEObject; //gameObject for hit e to use text

  

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //if colliding with player
        {
            hitEObject.SetActive(true);
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
