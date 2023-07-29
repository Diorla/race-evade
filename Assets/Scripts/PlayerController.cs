using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;
    private float speed = 5.0f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    // TODO: Make car mass affects its speed and maneuverability.
    void Start()
    {

    }

     // Update is called once per frame
     void Update()
    {
        // Get player inputs: arrows or a-w-d-s keyboard
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);


        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // up indicates the y-axis
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
     }

}
