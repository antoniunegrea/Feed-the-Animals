using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 16.0f;
    public float xRange = 9.0f;
    public float zTopLimit = 12.0f;
    public float zDownLimit = 3.0f;

    public GameObject projectilePrefab;
    public Joystick joystick;

    void Update()
    {
        //hold the player in the scene by 2 limits (horizontal)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //hold the player in the scene by 2 limits (vertical)
        if (transform.position.z < zDownLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zDownLimit);
        }
        else if (transform.position.z > zTopLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zTopLimit);
        }

        //getting the input
        horizontalInput = joystick.Horizontal;
        verticalInput = joystick.Vertical;

        //moving the player
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);

        //Shooting
        if (horizontalInput == 0 && verticalInput == 0) 
        {
            if (Input.touchCount == 1)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    Vector3 projectilePosition = new Vector3(transform.position.x, 0.5f, transform.position.z + 2.0f);
                    Instantiate(projectilePrefab, projectilePosition, projectilePrefab.transform.rotation);
                }
            }
        }
        else
        {
            if (Input.touchCount == 2)
            {
                Touch touch0 = Input.GetTouch(0);
                Touch touch = Input.GetTouch(1);

                if (touch.phase == TouchPhase.Began)
                {
                    Vector3 projectilePosition = new Vector3(transform.position.x, 0.5f, transform.position.z + 2.0f);
                    Instantiate(projectilePrefab, projectilePosition, projectilePrefab.transform.rotation);
                }
            }
        }

        
        
    }

}
