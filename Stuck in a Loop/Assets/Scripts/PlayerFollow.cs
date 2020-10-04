using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Transform cameraTransform;
    public Vector3 startingPosition;
    public float yMin;
    public float yMax;
    public float xMin;
    public float xMax;

    
    void Start()
    {
        cameraTransform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x > xMin && playerTransform.position.x < xMax)
        {
            cameraTransform.position = new Vector3(playerTransform.position.x, cameraTransform.position.y, cameraTransform.position.z);
        }
        if (playerTransform.position.y > yMin && playerTransform.position.y < yMax)
        {
            cameraTransform.position = new Vector3(cameraTransform.position.x, playerTransform.position.y, cameraTransform.position.z);
        }
    }
}
