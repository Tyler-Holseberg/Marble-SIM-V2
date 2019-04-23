﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollision : MonoBehaviour
{
    public AudioClip marbletoWoodSound;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = marbletoWoodSound;
    }

    void OnCollisionEnter(Collision other)
    {

        switch (other.gameObject.name)
        {
            case "table":
                GetComponent<AudioSource>().Play();
                break;

            //also play that sound for collisions with blocks?
        }
    }
}