using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject marble;
    public GameObject Portal2;
    public Vector3 tempVelocity;
    public Vector3 direction;
    public GameObject dirTarget;
    // Start is called before the first frame update
    void Start()
    {
        //change this so this is updated as the portal moves and test in update
        Vector3 direction = dirTarget.transform.position - Portal2.transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        direction = dirTarget.transform.position - Portal2.transform.position;
        print(direction);
        print(dirTarget.transform.position);
        print(Portal2.transform.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Marble")
        {
           
            
            tempVelocity = marble.GetComponent<Rigidbody>().velocity;
            marble.GetComponent<Rigidbody>().velocity = (direction.normalized * tempVelocity.magnitude) * 2;
            //print(marble.GetComponent<Rigidbody>().velocity);
            //print((direction.normalized * tempVelocity.magnitude) * 2);
            marble.transform.position = Portal2.transform.position;
           // marble.GetComponent<Rigidbody>().angularVelocity = tempVelocity.GetComponent<Rigidbody>().angularVelocity;


        }
    }


}

