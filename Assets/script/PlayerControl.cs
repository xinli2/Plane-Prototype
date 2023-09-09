using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float verticalInput;
    private float forwardInput;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move the horizontal to forword
        forwardInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Moves the car forward based on horizontal input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the car based on vertical input
        transform.Rotate(Vector3.right, turnSpeed * verticalInput * Time.deltaTime);
    }
}
