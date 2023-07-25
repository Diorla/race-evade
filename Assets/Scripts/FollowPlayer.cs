using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -10);
    public string cameraType = "far";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(cameraType == "far")
            {
                cameraType = "close";
                offset = new Vector3(0, 5, -3);
            } else
            {
                cameraType = "far";
                offset = new Vector3(0, 5, -10);
            }
        }
        // Offset the camera behind the player position
        transform.position = player.transform.position + offset;
    }
}
