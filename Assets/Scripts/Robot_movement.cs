using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_movement : MonoBehaviour
{   
    // Private class variables
    Rigidbody rb;

    int ballCount;

    float vertical;

    bool previousPressed;

    // Public parameters
    public float robotSpeed = 5;
    public float turnSpeed = 5;

    public GameObject practiceBall;
    public Vector3 ballSpawnLocation;

    void Start()
    {
        previousPressed = false;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");

        Debug.DrawRay(transform.position, transform.forward * 5, Color.red);

        if (vertical > 0.1 || vertical < -0.1)
        {
            rb.velocity = transform.forward * robotSpeed * vertical;
        }

        
        if (Input.GetAxisRaw("Right Button") == 1 && ballCount < 100)
        {
            if (!previousPressed)
            {
                previousPressed = true;
                Instantiate(practiceBall).transform.position = ballSpawnLocation;
                ballCount++;
            }
        }
        else if (Input.GetAxisRaw("Right Button") == 0)
        {
            previousPressed = false;
        }

        // Use right stick horizontal axis to turn robot
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + Input.GetAxisRaw("Mouse X") * turnSpeed * Time.deltaTime, 0f);

    }
}
