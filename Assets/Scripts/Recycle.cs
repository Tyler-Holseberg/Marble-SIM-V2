using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycle : MonoBehaviour
{
    public GameObject flat;
    public GameObject rampBottom;
    public GameObject RampTop;
    private Quaternion flatStartRot;
    private Quaternion bottomStartRot;
    private Quaternion topStartRot;
    private GameObject flatTemp;
    private GameObject rampBottomTemp;
    private GameObject RampTopTemp;



    private float waitTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        flatTemp = new GameObject();
        flatTemp.transform.position = flat.transform.position;
        flatTemp.transform.rotation = flat.transform.rotation;

        rampBottomTemp = new GameObject();
        rampBottomTemp.transform.position = rampBottom.transform.position;
        rampBottomTemp.transform.rotation = rampBottom.transform.rotation;

        RampTopTemp = new GameObject();
        RampTopTemp.transform.position = RampTop.transform.position;
        RampTopTemp.transform.rotation = RampTop.transform.rotation;
        //trackStartPos = track.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.tag == "Flat")
        {
            //StartCoroutine(ResetTrackAfterSeconds(waitTime));

            other.transform.position = flatTemp.transform.position;
            other.transform.rotation = flatTemp.transform.rotation;

        }
        else if (other.gameObject.tag == "Bottom")
        {
            other.transform.position = rampBottomTemp.transform.position;
            other.transform.rotation = rampBottomTemp.transform.rotation;
        }
        else if (other.gameObject.tag == "Top")
        {
            other.transform.position = RampTopTemp.transform.position;
            other.transform.rotation = RampTopTemp.transform.rotation;
        }

    }


    /*I dont think we need to use a coroutine for this

    IEnumerator ResetTrackAfterSeconds(float seconds) 
    {
        print("WAITING " + waitTime + " SECONDS!");
        yield return new WaitForSeconds(seconds);
        //flat.transform.position = flatTemp.transform.position;
        Debug.Log("whats going on here");
    }
    
    */





    // Update is called once per frame
    void Update()
    {
    }


}
