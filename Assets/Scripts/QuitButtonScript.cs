﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball") {
            print("problem is scene switching");
            Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
