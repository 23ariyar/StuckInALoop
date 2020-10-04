using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 3f;
    public float jumpSpeed = 3f;
    private Transform playerTransform;
    private float movement = 0f;
    private Rigidbody2D rigidBody;
    bool isgrounded = true;
    public Animator animator;
    public string areaName;
    public Transform cameraTransform;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {

        movement = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(movement));

        if (movement > 0f) //Moving to the right
        {
            rigidBody.velocity = new Vector2(movement * playerSpeed, rigidBody.velocity.y);
            playerTransform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        else if (movement < 0f) //Moving to the left
        {
            rigidBody.velocity = new Vector2(movement * playerSpeed, rigidBody.velocity.y);
            playerTransform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        }
        else //Velocity 0
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && isgrounded == true) //Jumping
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
           
        }
        if (areaName == "MainArea" && playerTransform.position.x < 88f)
        {
            cameraTransform.position = new Vector3(cameraTransform.position.x, 32f, cameraTransform.position.z); //this is very fragile!!!!!! moving things around will mess this up
            playerTransform.position = new Vector3(119f, 28f, 90f);
            areaName = "CaveAreaOne";

        }
        else if (areaName == "CaveAreaOne" && playerTransform.position.x > 119f)
        {
            cameraTransform.position = new Vector3(cameraTransform.position.x, 56f, cameraTransform.position.z); //this is very fragile!!!!!! moving things around will mess this up
            playerTransform.position = new Vector3(90f, 53f, 95f);
            areaName = "MainArea";

        }
    }


    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform") //If it's on top of a platform, it should be grounded
        {
            isgrounded = true;
            
            
        }
       
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform") //once it exits a platform, it is no longer grounded
        {
            isgrounded = false;
        }
        
    }


}
