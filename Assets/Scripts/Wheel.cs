using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    private float rotateSpeed = 100f;

    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical");



        transform.Rotate(Vector3.right, Time.deltaTime * rotateSpeed * verticalInput);
    }
}
