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
    private Rigidbody marble;
    // Start is called before the first frame update
    void Start()
    {
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
            this.transform.position = endPos;
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

            scored = true;
            marble.transform.position = startPos; //commented out to fix reset button
            score.MarblesScored += 1;
            




            /* commented out to test a different method of keeping score
            scored = true;
            endPos = marble.transform.position;
            if (scored == false)
            {
                score.MarblesScored += 1;
            }
           
            */

        }
    }
}
