using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float speed = 2.5f;
    public Vector2 leftAxis;
    // Start is called before the first frame update
    void Start()
    {
       
       
       // print(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick));
        //leftAxis = (OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick));
        
    }

    

    void Update()
    {
       // print(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick));
       // leftAxis = (OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick));
        Vector3 pos = transform.position;

        //pos.z += speed * leftAxis.y * Time.deltaTime;
        //pos.x += speed * leftAxis.x * Time.deltaTime;

        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
