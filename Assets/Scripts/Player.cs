using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(50.0f, 0, 0); // Her eksende dönme hýzý

    void Start()
    {
        
    }

    void Update()
    {
        Movement();

        if (transform.position.x > 10.5f)
        {
            transform.position = new Vector3(-10.61f, 0, transform.position.z);
        }
        else if (transform.position.x < -10.65f)
        {
            transform.position = new Vector3(10.4f, 0, transform.position.z);
        }

    }

    void Movement()
    {
        float verticalInput = Input.GetAxis("Vertical"); // W, S
        Vector3 directions = new Vector3(0, 0, verticalInput);
        transform.Translate(directions * 4.2f * Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal"); // A, D
        transform.Rotate(0, horizontalInput, 0);

        // Nesnenin rotation X bileþenini sýfýrlama
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);

        // Nesnenin position Y bileþenini sýfýrlama
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);

    }
}
