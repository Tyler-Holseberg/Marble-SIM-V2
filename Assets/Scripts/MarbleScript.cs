using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarbleScript : MonoBehaviour
{
    ScoreScript score;
    private Vector3 startPos;
    private Vector3 endPos;
    public bool scored;
    public Rigidbody marble;
    public AudioClip marbletoCupSound;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        score = FindObjectOfType<ScoreScript>();
        endPos = this.transform.position;
        startPos = this.transform.position;
        scored = false;
        marble = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //added this to an if so that time stops when the ball is scored
        if(scored == false)
        {
            score.TimePassed += Time.deltaTime;

        }
        //score.TimePassed += Time.deltaTime;

        if (scored == true)
        {
            this.transform.position = new Vector3(0, 0, 0); //endPos;
            marble.velocity = new Vector3(0, 0, 0);
            marble.angularVelocity = new Vector3(0, 0, 0);
        }
    }
    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.name=="Floor"){
            this.transform.position = startPos;
            marble.velocity = new Vector3(0, 0, 0);
            marble.angularVelocity = new Vector3(0, 0, 0);
                   


        }
        else if (target.gameObject.name == "Goal")
        {
            GetComponent<AudioSource>().clip = marbletoCupSound;
            GetComponent<AudioSource>().Play();
            print("dumb");
            
            scored = true;
            //marble.transform.position = startPos; //commented out to fix reset button
            //marble.velocity = new Vector3(0, 0, 0);
            //marble.angularVelocity = new Vector3(0, 0, 0);
            score.MarblesScored += 1;


        }
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "antiGravity")
        {
            print("collision bruh");
            marble.GetComponent<Rigidbody>().useGravity = false;



        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "antiGravity")
        {
            //print("collision bruh");
            marble.GetComponent<Rigidbody>().useGravity = true;



        }
    }
}
