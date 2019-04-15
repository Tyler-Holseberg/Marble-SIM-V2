using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollision : MonoBehaviour
{
    public AudioSource audioClip;

    void Start()
    {
        audioClip = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "table")
        {
            audioClip.Play();
        }
    }
}