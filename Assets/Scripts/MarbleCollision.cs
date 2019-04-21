using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollision : MonoBehaviour
{
    public AudioClip marbleSound;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = marbleSound;
    }

    void OnCollisionEnter(Collision other)
    {

        switch (other.gameObject.name)
        {
            case "table":
                GetComponent<AudioSource>().Play();
                break;
        }
    }
}