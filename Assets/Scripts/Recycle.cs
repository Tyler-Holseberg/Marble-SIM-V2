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
        if (other.name == track.name)
        {
           StartCoroutine(ResetTrackAfterSeconds(waitTime));
        }
    }

    IEnumerator ResetTrackAfterSeconds(float seconds) 
    {
        print("WAITIG " + waitTime + " SECONDS!");
        yield return new WaitForSeconds(seconds);
        track.transform.position = trackStartPos;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
