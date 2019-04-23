using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollision : MonoBehaviour
{
    public AudioClip marbletoWoodSound;
    public AudioClip marbletoCupSound;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        //GetComponent<AudioSource>().clip = marbletoWoodSound;
    }

    void OnCollisionEnter(Collision other)
    {

        switch (other.gameObject.name)
        {
            case "table":
                GetComponent<AudioSource>().clip = marbletoWoodSound;
                GetComponent<AudioSource>().Play();
                break;

            case "menu":
                GetComponent<AudioSource>().clip = marbletoCupSound;
                GetComponent<AudioSource>().Play();
                break;
        }
    }
}