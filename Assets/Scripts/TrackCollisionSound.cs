using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCollisionSound : MonoBehaviour
{
    public AudioClip marbleRollingSound;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = marbleRollingSound ;
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
