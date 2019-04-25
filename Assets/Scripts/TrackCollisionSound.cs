using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCollisionSound : MonoBehaviour
{
    public AudioClip marbleRollingSound;
    public AudioClip woodCollision;
    // Start is called before the first frame update
    void Start()
    {
              
        GetComponent<AudioSource>().playOnAwake = false;
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {

        switch (other.gameObject.name)
        {
            case "marble":
                GetComponent<AudioSource>().clip = marbleRollingSound;
                GetComponent<AudioSource>().Play();
                break;

            case "table":
                GetComponent<AudioSource>().clip = woodCollision;
                GetComponent<AudioSource>().Play();
                break;

            case "track":
                GetComponent<AudioSource>().clip = woodCollision;
                GetComponent<AudioSource>().Play();
                break;
        }
    }
    void OnCollisionExit(Collision other)
    {

        switch (other.gameObject.name)
        {
            case "marble":
                GetComponent<AudioSource>().Stop();
                break;
        }
    }

    
}

