using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollisionCup : MonoBehaviour
{
    public AudioClip marbletoCupSound;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = marbletoCupSound;
    }

    void OnCollisionEnter(Collision other)
    {

        switch (other.gameObject.name)
        {
            case "menu":
                GetComponent<AudioSource>().Play();
                break;
        }
    }
}
