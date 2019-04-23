using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//this script works when attached to the marble
public class PlayButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                    

    }

    void OnTriggerEnter(Collider other)
    {
    
        switch (other.gameObject.name)
        {
            case "lev1":
                SceneManager.LoadScene("Level 1");
                break;
            case "lev2":
                SceneManager.LoadScene("Level 2");
                break;
            case "lev3":
                SceneManager.LoadScene("Level 3");
                break;
            case "freePlay":
                SceneManager.LoadScene("FreePlay");
                break;
            case "Menu":
                SceneManager.LoadScene("MenuScene");
                break;
            case "QuitCup":
                Application.Quit(0);
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
