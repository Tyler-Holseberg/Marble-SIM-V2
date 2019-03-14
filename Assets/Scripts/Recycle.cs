using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycle : MonoBehaviour
{
    public GameObject track;
    private Vector3 trackStartPos;
    private float waitTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        trackStartPos = track.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        //tried detecting by tag
        if (other.name == track.name)
        {
            Debug.Log("detected collision");
            StartCoroutine(ResetTrackAfterSeconds(waitTime));
        }
    }

    IEnumerator ResetTrackAfterSeconds(float seconds) 
    {
        print("WAITING " + waitTime + " SECONDS!");
        yield return new WaitForSeconds(seconds);
        track.transform.position = trackStartPos;
        Debug.Log("whats going on here");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
