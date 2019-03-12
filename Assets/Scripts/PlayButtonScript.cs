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
        if (other.gameObject.name == "PlayPlane")
        {
             SceneManager.LoadScene("FreePlay");
        }
        else if (other.gameObject.name == "QuitPlane")
        {
            Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
