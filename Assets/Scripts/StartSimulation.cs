﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSimulation : MonoBehaviour
{
    public GameObject marble;
    public GameObject startTrigger;
    public GameObject resetTrigger;

    private Vector3 marbleStartPos;

    // Start is called before the first frame update
    void Start()
    {
        marbleStartPos = marble.transform.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == startTrigger.name) 
        {
            marble.GetComponent<Rigidbody>().isKinematic = false;
            marble.GetComponent<Rigidbody>().useGravity = true;
        }

        if (other.gameObject.name == resetTrigger.name)
        {
            marble.GetComponent<Rigidbody>().isKinematic = true;
            marble.GetComponent<Rigidbody>().useGravity = false;

            marble.transform.position = marbleStartPos;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
