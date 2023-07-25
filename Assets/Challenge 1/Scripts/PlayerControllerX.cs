using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's Horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        // move the plane forward at a constant rate
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * 0.5f);

        //if(Input.GetKey("space"))
        //{
        //transform.Translate(Vector3.up * speed * Time.deltaTime * 0.2f);
        //}
        //else
        //{
        //transform.Translate(Vector3.up * speed * Time.deltaTime * -0.1f);
        //}

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
