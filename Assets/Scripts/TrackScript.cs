using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackScript : MonoBehaviour
{
    ScoreScript score;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        MarbleScript M = null;
        M = collision.gameObject.GetComponent<MarbleScript>();
        if (M != null)
        {
            score.TracksUsed++;
        }
    }
}
