using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//this script works when attached to the marble
public class PlayButtonScript : MonoBehaviour
{
    public AudioClip marbletoCupSound;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<AudioSource>().clip = marbletoCupSound;

    }

    void OnTriggerEnter(Collider other)
    {
    
        switch (other.gameObject.name)
        {
            case "lev1":
                print("what");
                //GetComponent<AudioSource>().Play();
                SceneManager.LoadScene("Level 1");
                break;
            case "lev2":
               // GetComponent<AudioSource>().Play();
                SceneManager.LoadScene("Level 2");
                break;
            case "lev3":
               // GetComponent<AudioSource>().Play();
                SceneManager.LoadScene("Level 3");
                break;
            case "freePlay":
              //  GetComponent<AudioSource>().Play();
                SceneManager.LoadScene("FreePlay");
                break;
            case "Menu":
              //  GetComponent<AudioSource>().Play();
                SceneManager.LoadScene("MenuScene");
                break;
            case "QuitCup":
              //  GetComponent<AudioSource>().Play();
                Application.Quit(0);
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
