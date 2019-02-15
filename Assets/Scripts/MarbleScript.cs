using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleScript : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;
    public bool scored;     //tyler changed this to public for debugging
    private Rigidbody marble;
    // Start is called before the first frame update
    void Start()
    {
        endPos = this.transform.position;
        startPos = this.transform.position;
        scored = false;
        marble = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scored == true)
        {
            this.transform.position = endPos;
            marble.velocity = new Vector3(0, 0, 0);
            marble.angularVelocity = new Vector3(0, 0, 0);
        }
    }
    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.name=="Floor"){
            this.transform.position = startPos;
            marble.velocity = new Vector3(0, 0, 0);
            marble.angularVelocity = new Vector3(0, 0, 0);
        }
        else if (target.gameObject.name == "Goal")
        {
            scored = true;
            endPos = marble.transform.position;
        }
    }
}
