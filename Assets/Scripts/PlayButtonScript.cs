using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            print("problem is scene switching");

            SceneManager.LoadScene("FreePlay");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
