using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonAnimation : MonoBehaviour
{
    public GameObject marble;
    public GameObject player;
    private Animator buttonPress;
    private Vector3 marbleStartPos;

    // Start is called before the first frame update
    void Start()
    {
        buttonPress = GetComponent<Animator>();
        marbleStartPos = marble.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            buttonPress.SetTrigger("Cube On");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == player.name) 
        {
            buttonPress.SetTrigger("Cube Off");
            marble.GetComponent<Rigidbody>().isKinematic = false;
            marble.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
